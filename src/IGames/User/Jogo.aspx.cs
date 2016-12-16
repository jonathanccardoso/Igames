using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.User
{
    public partial class Jogo : System.Web.UI.Page
    {
        public DAL.DALUsers daluser { get; set; }

        public Modelo.Usuario user { get; set; }

        public DAL.DALIcons dalicon { get; set; }

        public Modelo.Icone icon { get; set; }

        public DAL.DALFavorites dalfavorito { get; set; }

        public Modelo.Favorito favorito { get; set; }

        public Modelo.Favorito fav { get; set; }

        public DAL.DALGames daljogo { get; set; }

        public Modelo.Jogo jogo { get; set; }

        //avaliacao
        private bool avaliacao = false;

        public DAL.DALRates dalaval { get; set; }

        public Modelo.Avaliacao avali { get; set; }

        public List<Modelo.Jogo> destaque { get; set; }

        public List<Modelo.Jogo> recomendado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            hasUser();
            getUser();
            getIcon();
            getJogo();

            getRecomendado();

            pegarAvaliacao();
        }
        protected void Sair_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Session["email"] = null;
            Response.Redirect("~/Public/Index.aspx");
        }

        /*
         * mudar quando estiver sem favoritar
         * 
        <i class="material-icons">favorite_border</i>*/

        protected void pegarAvaliacao() {
            if (!Page.IsPostBack) {
                this.dalaval = new DAL.DALRates();
                this.daljogo = new DAL.DALGames();
//              this.avali = this.dalaval.Select(this.daljogo.SelectByName("2048").id, Session["id"].ToString());
                this.avali = DAL.DALRates.Select(DAL.DALGames.SelectByName("2048").id, user.id);
                if (DAL.DALRates.SelectByUser(user.id) != null)
                {
                    if (avali.numeroEstrelas == 1)
                    {
                        Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela2.ImageUrl = "~/Images/EstrelaApagada.png";
                        Estrela3.ImageUrl = "~/Images/EstrelaApagada.png";
                        Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                        Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                    }
                    else if (avali.numeroEstrelas == 2)
                    {
                        Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela3.ImageUrl = "~/Images/EstrelaApagada.png";
                        Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                        Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                    }
                    else if (avali.numeroEstrelas == 3)
                    {
                        Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                        Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                    }
                    else if (avali.numeroEstrelas == 4)
                    {
                        Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela4.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                    }
                    else if (avali.numeroEstrelas == 5)
                    {
                        Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela4.ImageUrl = "~/Images/EstrelaAcesa.png";
                        Estrela5.ImageUrl = "~/Images/EstrelaAcesa.png";
                    }
                    avaliacao = true;
                }
                
            }
        }

        protected void pegarFavorito()
        {
            if (!Page.IsPostBack)
            {
                this.dalfavorito = new DAL.DALFavorites();
                if (DAL.DALFavorites.SelectByUser(user.id) != null)
                {
                    Request.Form["favorito"] = "favorite";
                }
            }
        }

        protected void Estrela1_Click(object sender, EventArgs e)
        {
            this.dalaval = new DAL.DALRates();
            this.daljogo = new DAL.DALGames();
            Modelo.Avaliacao ava = new Modelo.Avaliacao(1, DAL.DALGames.SelectByName("2048").id, Session["id"].ToString());
            if (DAL.DALRates.Select(DAL.DALGames.SelectByName("2048").id, Session["id"].ToString()) != null)
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela3.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                DAL.DALRates.Delete(ava);
                DAL.DALRates.Insert(ava);
                this.avaliacao = false;
            }
            else {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela3.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                DAL.DALRates.Insert(ava);
                this.avaliacao = true;
            }
        }
        protected void Estrela2_Click(object sender, EventArgs e)
        {
            DAL.DALRates dalaval = new DAL.DALRates();
            DAL.DALGames daljogo = new DAL.DALGames();
            Modelo.Avaliacao ava = new Modelo.Avaliacao(2, DAL.DALGames.SelectByName("2048").id, Session["id"].ToString());
            if (DAL.DALRates.Select(DAL.DALGames.SelectByName("2048").id, Session["id"].ToString()) != null)
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                DAL.DALRates.Delete(ava);
                DAL.DALRates.Insert(ava);
                this.avaliacao = false;
            }
            else
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                DAL.DALRates.Insert(ava);
                this.avaliacao = true;
            }
        }
        protected void Estrela3_Click(object sender, EventArgs e)
        {
            DAL.DALRates dalaval = new DAL.DALRates();
            DAL.DALGames daljogo = new DAL.DALGames();
            Modelo.Avaliacao ava = new Modelo.Avaliacao(3, DAL.DALGames.SelectByName("2048").id, Session["id"].ToString());
            if (DAL.DALRates.Select(DAL.DALGames.SelectByName("2048").id, Session["id"].ToString()) != null)
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                DAL.DALRates.Delete(ava);
                DAL.DALRates.Insert(ava);
                this.avaliacao = false;
            }
            else
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                DAL.DALRates.Insert(ava);
                this.avaliacao = true;
            }
        }
        protected void Estrela4_Click(object sender, EventArgs e)
        {
            DAL.DALRates dalaval = new DAL.DALRates();
            DAL.DALGames daljogo = new DAL.DALGames();
            Modelo.Avaliacao ava = new Modelo.Avaliacao(4, DAL.DALGames.SelectByName("2048").id, Session["id"].ToString());
            if (DAL.DALRates.Select(DAL.DALGames.SelectByName("2048").id, Session["id"].ToString()) != null)
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela4.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                DAL.DALRates.Delete(ava);
                DAL.DALRates.Insert(ava);
                this.avaliacao = false;
            }
            else
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela4.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                DAL.DALRates.Insert(ava);
                this.avaliacao = true;
            }
        }
        protected void Estrela5_Click(object sender, EventArgs e)
        {
            DAL.DALRates dalaval = new DAL.DALRates();
            Modelo.Avaliacao ava = new Modelo.Avaliacao(5, DAL.DALGames.SelectByName("2048").id, Session["id"].ToString());
            if (DAL.DALRates.Select(DAL.DALGames.SelectByName("2048").id, Session["id"].ToString()) != null)
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela4.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela5.ImageUrl = "~/Images/EstrelaAcesa.png";
                DAL.DALRates.Delete(ava);
                DAL.DALRates.Insert(ava);
                this.avaliacao = false;
            }
            else
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela4.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela5.ImageUrl = "~/Images/EstrelaAcesa.png";
                DAL.DALRates.Insert(ava);
                this.avaliacao = true;
            }
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
                this.daluser = new DAL.DALUsers();
                this.user = DAL.DALUsers.Select(Session["id"].ToString());
            
        }

        protected void getIcon()
        {
            this.dalicon = new DAL.DALIcons();
            this.icon = DAL.DALIcons.Select(this.user.Icone_id);
        }
        
        protected void getJogo()
        {
            this.daljogo = new DAL.DALGames();
            this.jogo = DAL.DALGames.Select(DAL.DALGames.SelectByName(Request.QueryString["jogo"]).id);
        }

        protected void Sair()
        {
            if (Request.QueryString["exit"] != null)
            {
                Session.Contents.RemoveAll();
            }
        }

        protected void AddFavorito_Click(object sender, EventArgs e)
        {
            this.dalfavorito = new DAL.DALFavorites();
            this.favorito = new Modelo.Favorito(user.id, jogo.id);
            DAL.DALFavorites.Insert(favorito);
            if (DAL.DALFavorites.SelectByUser(user.id) != null)
            {
                Request.Form["favorito"] = "favorite_border";
            }
            else if (DAL.DALFavorites.SelectByUser(user.id) == null)
            {
                Request.Form["favorito"] = "favorite";
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