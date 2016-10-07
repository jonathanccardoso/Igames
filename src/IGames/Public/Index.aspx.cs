﻿using System;
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
                if (Roles.IsUserInRole(Membership.GetUserNameByEmail(Session["email"].ToString()), "Administrador"))
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
}