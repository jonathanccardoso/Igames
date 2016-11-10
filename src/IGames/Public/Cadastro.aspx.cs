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
            if (nome.Text != null && senha.Text != null && email.Text != null && confsenha.Text != null) {
                string UserName = nome.Text,
                       Password = senha.Text,
                       Email = email.Text;
                Membership.CreateUser(UserName, Password, Email);
                Roles.AddUserToRole(UserName, "Usuario");
                Modelo.Usuario user = new Modelo.Usuario(Membership.GetUser(UserName).ProviderUserKey.ToString(), UserName, Email, "imagens/", 0);
                DAL.DALUsers usuario = new DAL.DALUsers();
                usuario.Insert(user);
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