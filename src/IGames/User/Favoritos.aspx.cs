using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.User
{
    public partial class Favoritos : System.Web.UI.Page
    {
        public DAL.DALUsers daluser { get; set; }

        public Modelo.Usuario user { get; set; }

        public DAL.DALIcons dalicon { get; set; }

        public Modelo.Icone icon { get; set; }

        public DAL.DALFavorites dalfavorito { get; set; }

        public List<Modelo.Favorito> favoritos { get; set; }

        public DAL.DALGames daljogo { get; set; } 
         
        public List<Modelo.Jogo> jogos { get; set; }

        //
        public List<Modelo.Jogo> online { get; set; }

        public List<Modelo.Jogo> recomendado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            initPage();
            getJogos();
            getFavoritos();
        }

        protected void initPage()
        {
            this.online = Metodos.getJogos();
            this.recomendado = Metodos.getJogosRecomendados();
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

        protected void getJogos()
        {
            if (!Page.IsPostBack)
            {
                this.daljogo = new DAL.DALGames();
                this.jogos = DAL.DALGames.SelectAll();
            }
        }
        protected void getFavoritos()
        { 
            if (!Page.IsPostBack)
            {
                this.dalfavorito = new DAL.DALFavorites();
                this.favoritos = DAL.DALFavorites.SelectAll();
            }
        }

        protected void Sair(object sender, EventArgs e)
        {
            Session.Contents.RemoveAll();
            Response.Redirect("~/Public/Login.aspx");
        }
    }
}