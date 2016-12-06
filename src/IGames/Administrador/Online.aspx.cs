﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Online : System.Web.UI.Page
    {
        public DAL.DALGamesCategories daljogocategoria { get; set; }

        public Modelo.JogoCategoria jogocategoria { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getCategories();
            }
        }

        protected void addGame_Click(object sender, EventArgs e)
        {
                if (Categorias.SelectedItem.Value != "Escolha uma categoria")
                {
                    uploadGame();
                    uploadImage();
                    DAL.DALGames jogo = new DAL.DALGames();
                    Modelo.Jogo jog = new Modelo.Jogo("Online/" + UploadGame.FileName, TextBox1.Text, "Images/" + UploadImage.FileName, TextBox2.Text);
                    jogo.Insert(jog);
                    this.daljogocategoria = new DAL.DALGamesCategories();
                    this.jogocategoria = new Modelo.JogoCategoria(jog.id, int.Parse(Categorias.SelectedItem.Value));
                    this.daljogocategoria.Insert(this.jogocategoria);
                }
                Response.Redirect("~/Administrador/Index.aspx");
        }

        protected void getCategories()
        {
            DAL.DALCategories cat = new DAL.DALCategories();
            List<Modelo.Categoria> cats = cat.SelectAll();
            this.Categorias.DataSource = cats;
            this.Categorias.DataTextField = "Descricao";
            this.Categorias.DataValueField = "ID";
            this.DataBind();
            Categorias.Items.Insert(0, "Escolha uma categoria");
        }

        protected void uploadGame() {
            string path = Server.MapPath("~") + "Online/" + TextBox2.Text;
            if (UploadGame.HasFile)
            {
                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path);
                }
                foreach (HttpPostedFile file in UploadGame.PostedFiles) {
                    file.SaveAs(Server.MapPath("~") + "Online/" + file.FileName);
                }
            }
        }
        protected void uploadImage()
        {
            if (UploadImage.HasFile)
            {
                UploadImage.PostedFile.SaveAs(Server.MapPath("~") + "Images/" + UploadImage.FileName);
            }
        }

        protected void Sair(object sender, EventArgs e)
        {
            Session["id"] = null;
            Session["email"] = null;
            Response.Redirect("~/Public/Index.aspx");
        }

        protected void Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}