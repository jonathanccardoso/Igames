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
                if (Membership.ValidateUser(Membership.GetUserNameByEmail(email.Text), senha.Text))
                {
                    FormsAuthentication.SetAuthCookie(email.Text, true);
                    Session["id"] = Membership.GetUser(Membership.GetUserNameByEmail(email.Text)).ProviderUserKey;
                    Session["email"] = email.Text;
                    if (Roles.IsUserInRole(Membership.GetUserNameByEmail(email.Text), "Administrador"))
                    {
                        Response.Redirect("~/Administrador/Index.aspx");
                    }
                    else
                    {
                        Response.Redirect("~/User/Index.aspx");
                    }
                }
            }
        }

        protected void cadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Public/Cadastro.aspx");
        }
    }
}