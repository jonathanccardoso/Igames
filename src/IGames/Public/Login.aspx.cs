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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            if (email.Text != "" && senha.Text != "")
            {
                DAL.DALUsers daluser = new DAL.DALUsers();
                Modelo.Usuario user = daluser.Select(Membership.GetUser(Membership.GetUserNameByEmail(email.Text)).ProviderUserKey.ToString());
                if (Membership.ValidateUser(user.nome, user.senha))
                {
                    FormsAuthentication.SetAuthCookie(email.Text, true);
                    Session["id"] = user.id;
                    Session["email"] = user.email;
                    Session["senha"] = user.senha;
                    Response.Redirect("~/" + (user.administrador ? "Administrador" : "User") + "/Index.aspx");
                }
                else{
                    Response.Redirect("~/Public/Login.aspx");
                }
            }
        }

        protected void cadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Public/Cadastro.aspx");
        }
    }
}