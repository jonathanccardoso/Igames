using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        public Modelo.JogoCategoria jogocategoria { get; set; }

        public Modelo.Usuario user { get; set; }

        public Modelo.Icone icon { get; set; }

        private System.Drawing.Image imagem { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            hasUser();
            getUser();
            getIcon();

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
                    Modelo.Jogo jog = new Modelo.Jogo("Online/" + UploadGame.FileName, TextBox1.Text, this.imagem, TextBox2.Text, UploadImage.FileName);
                    DAL.DALGames.Insert(jog);
                    this.jogocategoria = new Modelo.JogoCategoria(jog.id, int.Parse(Categorias.SelectedItem.Value));
                    DAL.DALGamesCategories.Insert(this.jogocategoria);
                }
                Response.Redirect("~/Administrador/Index.aspx");
        }

        protected void getCategories()
        {
            List<Modelo.Categoria> cats = DAL.DALCategories.SelectAll();
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
                this.imagem = System.Drawing.Image.FromStream(UploadImage.PostedFile.InputStream);
            }
        }

        protected void Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
         
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
                this.icon = DAL.DALIcons.Select(this.user.Icone_id);
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