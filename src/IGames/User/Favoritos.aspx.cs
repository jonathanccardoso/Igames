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

        protected void Page_Load(object sender, EventArgs e)
        {
            hasUser();
            getUser();
            getIcon();
            getJogos();
            getFavoritos();
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
                this.favoritos = dalfavorito.SelectAll();
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