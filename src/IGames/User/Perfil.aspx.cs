using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.User
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             //seções de usuario...
            email_user.Text = Session["email"].ToString();
            Membership.GetUserNameByEmail(email_user.Text); //Usuario
            //Membership.GetUser(Membership.GetUserNameByEmail(email_user.Text)).GetPassword();
        }
        protected void EditarPerfil_Click(object sender, EventArgs e)
        {
            
        }

        }
    }