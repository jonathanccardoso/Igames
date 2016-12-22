using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.User
{
    public partial class Categorias : System.Web.UI.Page
    {
        public Modelo.Usuario user { get; set; }

        public Modelo.Icone icon { get; set; }

        public List<Modelo.Categoria> cats { get; set; }

        public DAL.DALGames daljogo { get; set; }

        public List<Modelo.Jogo> jogos { get; set; }

        public List<Modelo.Jogo> online { get; set; }

        public List<Modelo.JogoCategoria> jogoscategorias { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            initPage();
            if (!Page.IsPostBack)
            { 
                getCategories(); 
            }
        }

        protected void initPage()
        {
            this.online = Metodos.getJogos();
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

        protected void getCategories()
        {
            this.cats = DAL.DALCategories.SelectAll();
        }

        protected void getCategoria() 
        { 
            if (!Page.IsPostBack)
            {
                //ou DAL.DALjogocat
                this.cats = DAL.DALCategories.SelectAll();
            }
        }

        protected Modelo.Jogo getJogo(int jogo_id)
        {
            return DAL.DALGames.Select(jogo_id);
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