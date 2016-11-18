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
            //getCategories();
        }

        protected void addGame_Click(object sender, EventArgs e)
        {
            uploadGame();
            uploadImage();
            DAL.DALGames jogo = new DAL.DALGames();
            Modelo.Jogo jog = new Modelo.Jogo(jogo.SelectLast() + 1 ?? 1, "JogosDown/" + UploadGame.FileName, TextBox1.Text, "Images/" + UploadImage.FileName, TextBox2.Text, 0);
            jogo.Insert(jog);
        }

        protected void getCategories()
        {
            DAL.DALCategories cat = new DAL.DALCategories();
            List<Modelo.Categoria> cats = cat.SelectAll();
            Categorias.DataSource = cats;
            foreach (Modelo.Categoria ca in cats) {
                Categorias.DataTextField = ca.Descricao;
                Categorias.DataValueField = ca.Id.ToString();
            }
            Categorias.DataBind();
        }

        protected void uploadGame() {
            
            UploadGame.SaveAs("JogosDown/" + UploadGame.FileName);
        }

        protected void uploadImage()
        {
            UploadImage.SaveAs("Images/" + UploadImage.FileName);
        }

        protected void Sair(object sender, EventArgs e)
        {
            Session["id"] = null;
            Session["email"] = null;
            Response.Redirect("~/Public/Index.aspx");
        }
    }
}