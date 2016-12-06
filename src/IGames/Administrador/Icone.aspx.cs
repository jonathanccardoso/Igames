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
        public DAL.DALUsers daluser { get; set; }

        public Modelo.Usuario user { get; set; }

        public DAL.DALIcons dalicone { get; set; }

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

        //icone 
        //não pega ainda
        protected void getIcons()
        {
            if (!Page.IsPostBack)
            {
                this.dalicone = new DAL.DALIcons();
                this.icones = this.dalicone.SelectAll();
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
                this.dalicone = new DAL.DALIcons();
                this.ico = dalicone.Select(id);
                dalicone.Delete(ico);
                Response.Redirect("~/Administrador/Icone.aspx");
            }
        }

        protected void AddIcone_Click(object sender, EventArgs e)
        {
                uploadImage();
                DAL.DALIcons jogo = new DAL.DALIcons();
                Modelo.Icone jog = new Modelo.Icone("../Icone/" + UploadImage.FileName);
                jogo.Insert(jog);
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
                this.daluser = new DAL.DALUsers();
                this.user = daluser.Select(Session["id"].ToString());
            }
        }

        protected void getIcon()
        {
            if (!Page.IsPostBack)
            {
                this.dalicone = new DAL.DALIcons();
                this.icone = dalicone.Select(this.user.Icone_id);
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