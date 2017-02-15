using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames
{
    public partial class Sair : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Contents.RemoveAll();
            Response.Redirect("~/Public/Login.aspx");
        }
    }
}