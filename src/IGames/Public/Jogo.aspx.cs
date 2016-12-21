using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Public
{
    public partial class Jogo : System.Web.UI.Page
    {
        public Modelo.Usuario user { get; set; }

        public Modelo.Icone icon { get; set; }

        public DAL.DALGames daljogo { get; set; } 

        public Modelo.Jogo jogo { get; set; }
        //recomendados
        public List<Modelo.Jogo> destaque { get; set; }

        public List<Modelo.Jogo> recomendado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
             getRecomendado();
             getJogo();
             initPage();
        }
        protected void getRecomendado()
        {
            if (!Page.IsPostBack)
            {
                this.destaque = DAL.DALGames.SelectRandom();
            }
        }
        protected void initPage()
        {
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

        protected void getJogo() {
            this.jogo = DAL.DALGames.SelectByName(Request.QueryString["jogo"]);

        }
    }
}