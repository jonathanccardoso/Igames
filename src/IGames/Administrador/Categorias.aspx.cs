using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Categorias : System.Web.UI.Page
    {
        public Modelo.Usuario user { get; set; }

        public Modelo.Icone icon { get; set; }

        public List<Modelo.Categoria> cats { get; set; }

        public List<Modelo.Jogo> jogos { get; set; }

        public List<Modelo.JogoCategoria> jogoscategorias { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            initPage();

         if (!Page.IsPostBack)
            {
                getJogos();
                getCategories();
                getJogosCategorias();

                getCategoriasUpd();
                getCategoriasDel();
            }
        }
        protected void getCategoriasUpd()
        {
            List<Modelo.Categoria> cats = DAL.DALCategories.SelectAll();
            this.listCateUpd.DataSource = cats;
            this.listCateUpd.DataTextField = "Descricao";
            this.listCateUpd.DataValueField = "ID";
            this.DataBind();
            listCateUpd.Items.Insert(0, "Escolha uma categoria");
        }
        protected void getCategoriasDel()
        {
            List<Modelo.Categoria> cats = DAL.DALCategories.SelectAll();
            this.listCatDel.DataSource = cats;
            this.listCatDel.DataTextField = "Descricao";
            this.listCatDel.DataValueField = "ID";
            this.DataBind();
            listCatDel.Items.Insert(0, "Escolha uma categoria");
        }

        protected void initPage()
        {
            if (Session["id"] != null)
            {
                if (Metodos.hasUser(Session["id"].ToString() ?? ""))
                {
                    this.user = Metodos.getUser(Session["id"].ToString());
                    this.icon = Metodos.getIcone(this.user.Icone_id);
                    this.cats = DAL.DALCategories.SelectAll();
                    this.jogos = DAL.DALGames.SelectAll();
                    this.jogos = DAL.DALGames.SelectAll();
                }
            }
            else
            {
                Response.Redirect("~/Public/Login.aspx");
            }
        }

        protected void getCategories()
        {
            this.cats = DAL.DALCategories.SelectAll();
        }

        protected void getJogos()
        {
            this.jogos = DAL.DALGames.SelectAll();
        }

        protected Modelo.Jogo getJogo(int jogo_id)
        {
            return DAL.DALGames.Select(jogo_id);
        }

        protected void getJogosCategorias()
        {
            this.jogos = DAL.DALGames.SelectAll();
        }
        protected void AddCategoria_Click(object sender, EventArgs e)
        {
            string descricao = InstCategoria.Text;
            Modelo.Categoria cat = new Modelo.Categoria(descricao);
            DAL.DALCategories.Insert(cat);
            Response.Redirect("~/Administrador/Categorias.aspx");
        }
        protected void EdtCategoria_Click(object sender, EventArgs e)
        {
            if (listCateUpd.SelectedItem.Value != "Escolha uma categoria")
            {
                int id = int.Parse(listCateUpd.SelectedItem.Value);
                Modelo.Categoria cat = DAL.DALCategories.Select(id);
                cat.descricao = DescricaoUpdate.Text;
                DAL.DALCategories.Update(cat);
            }
            Response.Redirect("~/Administrador/Categorias.aspx");
        }
        protected void DelCategoria_Click(object sender, EventArgs e)
        {
            if (listCatDel.SelectedItem.Value != "Escolha uma categoria")
            {
                int id = int.Parse(listCatDel.SelectedItem.Value);
                Modelo.Categoria cat = DAL.DALCategories.Select(id);
                DAL.DALCategories.Delete(cat);
            }
            Response.Redirect("~/Administrador/Categorias.aspx");
        }

        protected void Sair(object sender, EventArgs e)
        {
            Session.Contents.RemoveAll();
            Response.Redirect("~/Public/Login.aspx");
        }
    }
}