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
            if (nome.Text != null && senha.Text != null && email.Text != null && confsenha.Text != null)
            {
                DAL.DALUsers daluser = new DAL.DALUsers();
                Modelo.Usuario user = daluser.Select(Membership.GetUser(nome).ProviderUserKey.ToString());
                Membership.CreateUser(user.UserName, senha.Text, user.Email);
                Roles.AddUserToRole(user.UserName, "Usuario");
                daluser.Insert(user);
                FormsAuthentication.SetAuthCookie(user.Email, true);
                Session["id"] = user.Id;
                Session["email"] = user.Email;
                Response.Redirect("~/User/Index.aspx");
            }
            else
            {
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}