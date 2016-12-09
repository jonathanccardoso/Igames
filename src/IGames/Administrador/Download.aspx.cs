using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Download : System.Web.UI.Page
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
        }

        protected void addGame_Click(object sender, EventArgs e)
        {
            uploadGame();
            uploadImage();
            DAL.DALGames jogo = new DAL.DALGames();
            Modelo.Jogo jog = new Modelo.Jogo("Download/" + UploadGame.FileName, TextBox1.Text, "Images/" + UploadImage.FileName, TextBox2.Text);
            jogo.Insert(jog);

            Response.Redirect("~/Administrador/Index.aspx");
        }


        protected void uploadGame()
        {
            string path = Server.MapPath("~") + "Download/" + TextBox2.Text;
            if (UploadGame.HasFile)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                foreach (HttpPostedFile file in UploadGame.PostedFiles)
                {
                    file.SaveAs(Server.MapPath("~") + "Download/" + file.FileName);
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
                this.user = DAL.DALUsers.Select(Session["id"].ToString());
            }
        }

        protected void getIcon()
        {
            if (!Page.IsPostBack)
            {
                this.dalicon = new DAL.DALIcons();
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