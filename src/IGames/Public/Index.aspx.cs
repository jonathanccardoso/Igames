using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Public
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                DAL.DALUsers daluser = new DAL.DALUsers();
                Response.Redirect("~/" + (daluser.Select(Membership.GetUser(Membership.GetUserNameByEmail(Session["email"].ToString())).ProviderUserKey.ToString()).administrador ? "Administrador" : "User") + "/Index.aspx");
            }
        }
    }
}