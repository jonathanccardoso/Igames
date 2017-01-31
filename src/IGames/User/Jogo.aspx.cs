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
        public Modelo.Usuario user { get; set; }

        public Modelo.Icone icon { get; set; }

        public Modelo.Favorito favorito { get; set; }

        public Modelo.Favorito fav { get; set; }

        public Modelo.Jogo jogo { get; set; }

        //avaliacao
        private bool avaliacao = false;

        public Modelo.Avaliacao avali { get; set; }

        public List<Modelo.Jogo> destaque { get; set; }

        public List<Modelo.Jogo> recomendado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            getRecomendado();
            getJogo();
            initPage();
            pegarAvaliacao();
            pegarFavorito();
        }

        protected void initPage()
        {
            //  this.jogo = DAL.DALGames.Select(DAL.DALGames.SelectByName(Request.QueryString["jogo"]).id);
            //getRecomendado();
            //pegarAvaliacao();
            this.recomendado = Metodos.getJogosRecomendados();
            if (Session["id"] != null)
            {
                if (Metodos.hasUser(Session["id"].ToString() ?? ""))
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

        protected void pegarAvaliacao()
        {
            if (!Page.IsPostBack)
            {
                this.avali = DAL.DALRates.Select(DAL.DALGames.SelectByName(jogo.nome).id, user.id);
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
                if (DAL.DALFavorites.SelectByUser(user.id) != null)
                {
                    Request.Form["favorito"] = "favorite";
                }
            }
        }

        protected void Estrela1_Click(object sender, EventArgs e)
        {
            Modelo.Avaliacao ava = new Modelo.Avaliacao(1, DAL.DALGames.SelectByName(jogo.nome).id, Session["id"].ToString());
            if (DAL.DALRates.Select(DAL.DALGames.SelectByName(jogo.nome).id, Session["id"].ToString()) != null)
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
            else
            {
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
            Modelo.Avaliacao ava = new Modelo.Avaliacao(2, DAL.DALGames.SelectByName(jogo.nome).id, Session["id"].ToString());
            if (DAL.DALRates.Select(DAL.DALGames.SelectByName(jogo.nome).id, Session["id"].ToString()) != null)
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
            Modelo.Avaliacao ava = new Modelo.Avaliacao(3, DAL.DALGames.SelectByName(jogo.nome).id, Session["id"].ToString());
            if (DAL.DALRates.Select(DAL.DALGames.SelectByName(jogo.nome).id, Session["id"].ToString()) != null)
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
            Modelo.Avaliacao ava = new Modelo.Avaliacao(4, DAL.DALGames.SelectByName(jogo.nome).id, Session["id"].ToString());
            if (DAL.DALRates.Select(DAL.DALGames.SelectByName(jogo.nome).id, Session["id"].ToString()) != null)
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
            Modelo.Avaliacao ava = new Modelo.Avaliacao(5, DAL.DALGames.SelectByName(jogo.nome).id, Session["id"].ToString());
            if (DAL.DALRates.Select(DAL.DALGames.SelectByName(jogo.nome).id, Session["id"].ToString()) != null)
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

        protected void AddFavorito_Click(object sender, EventArgs e)
        {
            if (favoritos.Text == "favorite_border")
            {
                this.favorito = new Modelo.Favorito(user.id, jogo.id);
                DAL.DALFavorites.Insert(favorito);
                favoritos.Text = "favorite";
            }
            else
            {
                //this.favorito = new Modelo.Favorito(user.id, jogo.id);
                DAL.DALFavorites daluser = new DAL.DALFavorites();
                Modelo.Favorito favorito = DAL.DALFavorites.SelectByUser(user.id);
                DAL.DALFavorites.DeleteByUser(favorito);
                favoritos.Text = "favorite_border";
            }
        }

        protected void getRecomendado()
        {
            if (!Page.IsPostBack)
            {
                this.destaque = DAL.DALGames.SelectRandom();
            }
        }

        protected void getJogo()
        {
            this.jogo = DAL.DALGames.SelectByName(Request.QueryString["jogo"]);

        }

        protected void Sair()
        {
            if (Page.IsPostBack)
            {
                if (Session["sair"].ToString() == "1")
                {
                    Session.Contents.RemoveAll();
                    Response.Redirect("~/Public/Login.aspx");
                }
            }
        }
    }
}