﻿using System;
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
            Nome_user.Text = Session["nome"].ToString();
            email_user.Text = Session["email"].ToString();
            senha_user.Text = Session["senha"].ToString();

            Nome_user.Enabled = false;
            email_user.Enabled = false;
            senha_user.Enabled = false;
        }
        protected void EditarPerfil_Click(object sender, EventArgs e)
        {
            Nome_user.Enabled = true;
            email_user.Enabled = true;
            senha_user.Enabled = true;
        }

        /*protected void Habilitar() {
            if (Page.IsPostBack) { 
                //descobrir como fazer  
            }
        }*/

        protected void Editar_Click(object sender, EventArgs e)
        {
            
            //não esta inserido ainda

            string nome = Nome_user.Text;
            string email = email_user.Text;
            string senha = senha_user.Text;
            bool administrador = bool.Parse(Session["administrador"].ToString());
            int Icone_id = int.Parse(Session["iconeId"].ToString());

            DAL.DALUsers daluser = new DAL.DALUsers();
            Modelo.Usuario user = new Modelo.Usuario(nome, email, senha, administrador, Icone_id);
            daluser.Update(user);
        }

        /*protected void Editar() {
            if (Page.IsPostBack)
            {
                this.daluser.Update(this.user);
            }
        }*/
    }
}