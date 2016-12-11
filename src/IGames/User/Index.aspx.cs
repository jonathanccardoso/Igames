using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.User
{
    public partial class Index : System.Web.UI.Page
    {
        public Modelo.Usuario user { get; set; }

        public Modelo.Icone icon { get; set; }

        public List<Modelo.Jogo> online { get; set; }
        
        public List<Modelo.Jogo> destaque { get; set; }

        public List<Modelo.Jogo> recomendado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            getOnline();
            getDestaque();
            getRecomendado();

            initPage();
        }

        protected void initPage() {
            if (Metodos.hasUser(Session["id"].ToString()))
            {
                Response.Redirect("~/Public/Cadastro.aspx");
            }
            this.user = Metodos.getUser(Session["id"].ToString());
            this.icon = Metodos.getIcon(this.user.Icone_id);
        }

        protected void Sair()
        {
            if (Page.IsPostBack)
            {
                //Versão 01
                /**/
                Session.Abandon();
                Response.Redirect("~/Public/Index.aspx");
                //Versão 02
                /*
                Session.Contents.RemoveAll();*/
                //Versão 03
                /*
                if (Request.QueryString["exit"] != null)
                {
                    if (int.Parse(Request.QueryString["exit"].ToString()) == 1)
                    {
                        Session["id"] = null;
                        Session["email"] = null;
                        Response.Redirect("~/Public/Index.aspx");
                    }
                }*/
            }
        }
        protected void getOnline()
        {
            if (!Page.IsPostBack)
            {
                this.online = DAL.DALGames.SelectAll();
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