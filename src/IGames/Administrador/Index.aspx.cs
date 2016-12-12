using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Index : System.Web.UI.Page
    {
        public DAL.DALUsers daluser { get; set; }

        public Modelo.Usuario user { get; set; }

        public DAL.DALIcons dalicon { get; set; }

        public Modelo.Icone icon { get; set; }

        public List<Modelo.Jogo> jogonline { get; set; }

        public List<Modelo.Jogo> destaque { get; set; }

        public List<Modelo.Jogo> recomendado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            hasUser();
            getUser();
            getIcon();

            getOnline();
            getDestaque();
            getRecomendado();

            initPage();
        }
        protected void initPage()
        {
            if (Metodos.hasUser(Session["id"].ToString()))
            {
                Response.Redirect("~/Public/Cadastro.aspx");
            }
            this.user = Metodos.getUser(Session["id"].ToString());
            this.icon = Metodos.getIcon(this.user.Icone_id);
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

        protected void Sair_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Session["email"] = null;
            Response.Redirect("~/Public/Index.aspx");
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
                if (int.Parse(Request.QueryString["exit"].ToString()) == 1)
                {
                    Session["id"] = null;
                    Session["email"] = null;
                    Response.Redirect("~/Public/Index.aspx");
                }
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