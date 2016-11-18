﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("~/Public/Cadastro.aspx");
            }
        }
        protected void Sair_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Session["email"] = null;
            Response.Redirect("~/Public/Index.aspx");
        }
        protected void Confirmar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrador/" + (online.Checked ? "Online" : ((download.Checked) ? "Download" : "Index")) + ".aspx");
        }
    }
}