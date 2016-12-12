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

        public List<Modelo.Jogo> jogos { get; set; }

        public List<Modelo.JogoCategoria> jogoscategorias { get; set; }

        public DAL.DALCategories dalcat { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            initPage();
            if (!Page.IsPostBack)
            {
                getJogos();
                getCategories();
                getJogosCategorias();
            }
        }

        protected void initPage()
        {
            if (!Metodos.hasUser(Session["id"].ToString()))
            {
                this.user = Metodos.getUser(Session["id"].ToString());
                this.icon = Metodos.getIcon(this.user.Icone_id);
            }
            else
            {
                Response.Redirect("~/Public/Cadastro.aspx");
            }

        }

        protected void getCategories()
        {
            this.dalcat = new DAL.DALCategories();
            this.cats = this.dalcat.SelectAll();
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
    }
}