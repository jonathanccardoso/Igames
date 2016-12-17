﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Usuarios : System.Web.UI.Page
    {
        public List<Modelo.Usuario> users { get; set; } 

        public DAL.DALUsers daluser { get; set; }
        
        public List<Modelo.Icone> icones { get; set; }
       
        public DAL.DALIcons dalicone { get; set; }

        public DAL.DALUsers dalusuario { get; set; }
         
        public Modelo.Usuario user { get; set; }

        public DAL.DALIcons dalicon { get; set; }

        public Modelo.Icone icon { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            initPage();
        }

        protected void initPage()
        {
            this.users = DAL.DALUsers.SelectAll();
            this.icones = DAL.DALIcons.SelectAll();
            if (Session["id"] != null)
            {
                if (!Metodos.hasUser(Session["id"].ToString() ?? ""))
                {
                    this.user = Metodos.getUser(Session["id"].ToString());
                    this.icon = Metodos.getIcone(this.user.Icone_id);
                }
            }
            else
            {
                Response.Redirect("~/Public/Login.aspx");
            }
        }

        protected void DelUser_Click(object sender, EventArgs e)
        {
            // int id = int.Parse(listCatDel.SelectedItem.Value);
            string nomeUser = delUser.Text;
            Modelo.Usuario user = DAL.DALUsers.Select(nomeUser);
            DAL.DALUsers.Delete(user);
            Response.Redirect("~/Administrador/Usuarios.aspx");
        }

        protected void Sair()
        {
            if (Request.QueryString["exit"] != null)
            {
                Session.Contents.RemoveAll();
            }
        }
    }
}