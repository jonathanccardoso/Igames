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
        public Modelo.Usuario user { get; set; }

        public Modelo.Icone icone { get; set; }

        public Modelo.Icone ico { get; set; }

        public List<Modelo.Icone> icones { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getIcons();
                hasUser();
                getUser();
                getIcon();
            }
        }

        protected void getIcons()
        {
            if (!Page.IsPostBack)
            {
                this.icones = DAL.DALIcons.SelectAll();
            }
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

        protected void Delete()
        {
            if (Request.QueryString["delete"] != null)
            {
                int id = int.Parse(Request.QueryString["delete"].ToString());
                this.ico = DAL.DALIcons.Select(id);
                DAL.DALIcons.Delete(ico);
                Response.Redirect("~/Administrador/Icone.aspx");
            }
        }

        protected void AddIcone_Click(object sender, EventArgs e)
        {
                uploadImage();
                Modelo.Icone jog = new Modelo.Icone("../Icone/" + UploadImage.FileName);
                DAL.DALIcons.Insert(jog);
                Response.Redirect("~/Administrador/Icone.aspx");
        }

        protected void uploadImage()
        {
            if (UploadImage.HasFile)
            {
                UploadImage.PostedFile.SaveAs(Server.MapPath("~") + "Icone/" + UploadImage.FileName);
            }
        }

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
                this.user = DAL.DALUsers.Select(Session["id"].ToString());
            }
        }

        protected void getIcon()
        {
            if (!Page.IsPostBack)
            {
                this.icone = DAL.DALIcons.Select(this.user.Icone_id);
            }
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