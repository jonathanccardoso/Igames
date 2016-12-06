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
        public DAL.DALUsers daluser { get; set; }

        public Modelo.Usuario user { get; set; }

        public DAL.DALIcons dalicon { get; set; }

        public Modelo.Icone icon { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            hasUser();
            getUser();
            getIcon();
            InitTextBox();
        }
        /*protected void EditarPerfil_Click(object sender, EventArgs e)
        {   
            EditaPerfil.Click -= EditarPerfil_Click;
            EditaPerfil.Click += Editar_Click;
        }*/

        protected void InitTextBox() {
            if (Request.QueryString["edit"] == null)
            {
                Nome_user.Text = user.nome;
                Nome_user.Enabled = false;
                email_user.Text = user.email;
                email_user.Enabled = false;
                senha_user.Text = user.senha;
                senha_user.Enabled = false;
            }
        }

        protected void Habilitar() {
            if (Request.QueryString["edit"] != null)
            {
                if (int.Parse(Request.QueryString["edit"].ToString()) == 1)
                {
                    Nome_user.Enabled = true;
                    Nome_user.Text = user.nome;
                    email_user.Text = user.email;
                    email_user.Enabled = true;
                    senha_user.Text = user.senha;
                    senha_user.Enabled = true;  
                }
            }
        }

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
        protected void Excluir_Click(object sender, EventArgs e){
            string id = Session["id"].ToString(); 
            DAL.DALUsers daluser = new DAL.DALUsers();
            Modelo.Usuario user = daluser.Select(id);
            daluser.Delete(user); 
            Response.Redirect("~/Public/Index.aspx");
        }   
        /*protected void Editar() {
            if (Page.IsPostBack)
            {
                this.daluser.Update(this.user);
            }
        }*/
        protected void hasUser()
        {
            if (!Page.IsPostBack)
            {
                if (Session["id"] == null)
                {
                    Response.Redirect("~/Public/Cadastro.aspx");
                }
            }
        }

        protected void getUser()
        {
            if (!Page.IsPostBack)
            {
                this.daluser = new DAL.DALUsers();
                this.user = daluser.Select(Session["id"].ToString());
            }
        }

        protected void getIcon()
        {
            if (!Page.IsPostBack)
            {
                this.dalicon = new DAL.DALIcons();
                this.icon = dalicon.Select(this.user.Icone_id);
            }
        }

        protected void Sair()
        {
            if (Request.QueryString["exit"] != null)
            {
                if (int.Parse(Request.QueryString["exit"].ToString()) == 1)
                {
                    Session["id"] = null;
                    Session["email"] = null;
                    Response.Redirect("~/Public/Index.aspx");
                }
            }
        }
    }
}