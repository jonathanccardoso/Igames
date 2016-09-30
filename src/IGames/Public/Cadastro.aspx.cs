using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Public
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cadastrar_Click(object sender, EventArgs e)
        {
            if (nome.Text != null && senha.Text != null && email.Text != null) {
                string UserName = nome.Text,
                       Password = senha.Text,
                       Email = email.Text;
                Membership.CreateUser(UserName, Password, Email);
                Roles.AddUserToRole(UserName, "Usuario");
                string aSQLConecStr;
                aSQLConecStr = ConfigurationManager.ConnectionStrings["iGamesConnectionString"].ConnectionString;
                SqlConnection aSQLCon = new SqlConnection(aSQLConecStr);
                aSQLCon.Open();
                SqlCommand aSQL = new SqlCommand("INSERT INTO Usuario(UserName, email, iconeUrl, administrador, id) VALUES(@username, @email, @caminho, " + 0 + ", @id)", aSQLCon);
                aSQL.Parameters.AddWithValue("@username", UserName);
                aSQL.Parameters.AddWithValue("@email", Email);
                aSQL.Parameters.AddWithValue("@caminho", "imagens/");
                aSQL.Parameters.AddWithValue("@id", Membership.GetUser(UserName).ProviderUserKey);
                aSQL.ExecuteNonQuery();
                FormsAuthentication.SetAuthCookie(email.Text, true);
                Session["id"] = Membership.GetUser(UserName).ProviderUserKey;
                Session["email"] = Membership.GetUser(UserName).Email;
                Response.Redirect("~/User/Index.aspx");
            }
            else {
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}