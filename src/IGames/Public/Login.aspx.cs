using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Public
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            if (email.Text != "" && senha.Text != "")
            {
                DAL.DALUsers daluser = new DAL.DALUsers();
                Modelo.Usuario user = daluser.Select(Membership.GetUser(Membership.GetUserNameByEmail(email.Text)).ProviderUserKey.ToString());
                if (Membership.ValidateUser(user.UserName, senha.Text))
                {
                    FormsAuthentication.SetAuthCookie(email.Text, true);
                    Session["id"] = user.Id;
                    Session["email"] = user.Email;
                    Response.Redirect("~/" + (user.Adm == 1 ? "Administrador" : "User") + "/Index.aspx");
                }
            }
        }

        protected void cadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Public/Cadastro.aspx");
        }
    }
}