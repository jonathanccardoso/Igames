using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Online : System.Web.UI.Page
    {
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
                    Modelo.Jogo jog = new Modelo.Jogo("Jogos/" + UploadGame.FileName, TextBox1.Text, "Images/" + UploadImage.FileName, TextBox2.Text);
                    jogo.Insert(jog);
                }
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
            if (UploadGame.HasFile)
            {
                foreach (HttpPostedFile file in UploadGame.PostedFiles) {
                    //ta dando erro
                    //bugou meu cerebro
                    //faz o passinho do romano
                    //falta criar diretorio
                    file.SaveAs(Server.MapPath("~") + "Jogos/" + file.FileName);
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