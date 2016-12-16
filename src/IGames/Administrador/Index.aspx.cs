using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Index : System.Web.UI.Page
    {
        public Modelo.Usuario user { get; set; }

        public Modelo.Icone icon { get; set; }

        public List<Modelo.Jogo> jogonline { get; set; }

        public List<Modelo.Jogo> destaque { get; set; }

        public List<Modelo.Jogo> recomendado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            getOnline();
            getDestaque();
            getRecomendado();
            initPage();
        }

        protected void initPage()
        {
            this.jogonline = Metodos.getJogos();
            this.destaque = Metodos.getJogosDestaque();
            this.recomendado = Metodos.getJogosRecomendados();
            if (Session["id"] != null)
            {
                if (!Metodos.hasUser(Session["id"].ToString() ?? ""))
                {
                    this.user = Metodos.getUser(Session["id"].ToString());
                    this.icon = Metodos.getIcone(this.user.Icone_id);
                    Response.Redirect("~/" + (user.administrador ? "Administrador" : "User") + "/Index.aspx");
                }
            }
        }

        protected void Confirmar_Click(object sender, EventArgs e)
        {
            //erro no online.Checked
            //Response.Redirect("~/Administrador/" + (online.Checked ? "Online" : ((download.Checked) ? "Download" : "Index")) + ".aspx");
        }

        protected void Sair()
        {
            if (Request.QueryString["exit"] != null)
            {
                Session.Contents.RemoveAll();
            }
        }

        protected void getOnline()
        {
            if (!Page.IsPostBack)
            {
                this.jogonline = DAL.DALGames.SelectAll();
            }
        }

        protected void getDestaque()
        {
            if (!Page.IsPostBack)
            {
                this.destaque = DAL.DALGames.SelectTop();
            }
        }

        protected void getRecomendado()
        {
            if (!Page.IsPostBack)
            {
                this.destaque = DAL.DALGames.SelectRandom();
            }
        }
    }
}