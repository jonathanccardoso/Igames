using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Icone : System.Web.UI.Page
    {
        public List<Modelo.Icone> icones { get; set; }

        public DAL.DALIcons dalicone { get; set; }

        public Modelo.Icone icone { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            getIcons();
        }

        //icone 
        //não pega ainda
        protected void getIcons()
        {
            this.dalicone = new DAL.DALIcons();
            this.icones = this.dalicone.SelectAll();
        }

        //protected void getIconeDel() 
        //{
        //    DAL.DALCategories cat = new DAL.DALCategories();
        //    List<Modelo.Categoria> cats = cat.SelectAll();
        //    this.listCatDel.DataSource = cats;
        //    this.listCatDel.DataTextField = "Descricao";
        //    this.listCatDel.DataValueField = "ID";
        //    this.DataBind();
        //    listCatDel.Items.Insert(0, "Escolha uma categoria");
        //}

        /*protected void Add() {
            uploadImage();
            this.icone = new Modelo.Icone("Icone/" + UploadImage.FileName);
            this.dalicone.Insert(icone);
            Response.Redirect("~/Administrador/Index.aspx");
        }*/

        protected void AddIcone_Click(object sender, EventArgs e)
        {
                uploadImage();
                DAL.DALIcons jogo = new DAL.DALIcons();
                Modelo.Icone jog = new Modelo.Icone ( "Icone/" + UploadImage.FileName);
                jogo.Insert(jog);
                Response.Redirect("~/Administrador/Index.aspx");
        }

        protected void uploadImage()
        {
            if (UploadImage.HasFile)
            {
                UploadImage.PostedFile.SaveAs(Server.MapPath("~") + "Icone/" + UploadImage.FileName);
            }
        }

        //protected void DelIcone_Click(object sender, EventArgs e)
        //{ 
        //    int id = int.Parse(listCatDel.SelectedItem.Value);
        //    DAL.DALIcons dalicone = new DAL.DALIcons();
        //    Modelo.Icone ico = dalicone.Select(id);
        //    dalicone.Delete(ico);
        //    Response.Redirect("~/Administrador/Index.aspx");
        //}
    }
}