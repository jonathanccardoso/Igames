﻿using System;
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
        public string email { get { return Request.Form["email"]; } }

        public string senha { get { return Request.Form["senha"]; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void login()
        {
            if (Page.IsPostBack)
            {
                if (this.email != "" && this.senha != "")
                {
                    Modelo.Usuario user = DAL.DALUsers.Select(Membership.GetUser(Membership.GetUserNameByEmail(email)).ProviderUserKey.ToString());
                    if (this.email == user.email && this.senha == user.senha)
                    {
                        if (Membership.ValidateUser(Membership.GetUserNameByEmail(email), this.senha))
                        {
                            FormsAuthentication.SetAuthCookie(email, true);
                            Session["id"] = user.id;
                            Session["nome"] = user.nome;
                            Session["email"] = user.email;
                            Session["senha"] = user.senha;
                            Session["iconeId"] = user.Icone_id;
                            Session["sair"] = 1;
                            Response.Redirect("~/" + (user.administrador ? "Administrador" : "User") + "/Index.aspx");
                        }
                        else
                        {
                            Response.Redirect("~/Public/Login.aspx");
                        }
                    }
                }
            }
        }
    }
}