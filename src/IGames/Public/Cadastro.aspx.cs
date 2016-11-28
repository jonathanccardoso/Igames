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
                Modelo.Usuario user = new Modelo.Usuario(nome.Text, email.Text, senha.Text, false, Convert.ToInt32(Request.QueryString["iconeId"]));
                Membership.CreateUser(user.nome, senha.Text, user.email);
                Roles.AddUserToRole(user.nome, "Usuario");
                daluser.Insert(user);
                FormsAuthentication.SetAuthCookie(user.email, true);
                Session["id"] = user.id;
                Session["email"] = user.email;
                Response.Redirect("~/User/Index.aspx");
            }
            else
            {
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}