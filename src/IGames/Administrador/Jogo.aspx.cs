using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Jogo : System.Web.UI.Page
    {
        public DAL.DALUsers daluser { get; set; }

        public Modelo.Usuario user { get; set; }

        public DAL.DALIcons dalicon { get; set; }

        public Modelo.Icone icon { get; set; }

        public DAL.DALFavorites dalfavorito { get; set;}

        public Modelo.Favorito favorito { get; set; }

        public DAL.DALGames daljogo { get; set; }

        public Modelo.Jogo jogo { get; set; }
        //avaliacao
        private bool avaliacao = false;

        public DAL.DALRates dalaval { get; set; }

        public Modelo.Avaliacao avali { get; set; }
        //recomendados
        public List<Modelo.Jogo> destaque { get; set; }

        public List<Modelo.Jogo> recomendado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            initPage();
            getRecomendado();
            getJogo();
            pegarAvaliacao();
        }
        protected void getJogo()
        {
            this.jogo = DAL.DALGames.SelectByName(Request.QueryString["jogo"]);
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
                }
            }
            else
            {
                Response.Redirect("~/Public/Login.aspx");
            }
        }

        //excluir jogo
        protected void Confirmar_Click(object sender, EventArgs e)
        {
            string JogoUrl = this.jogo.jogoUrl;
            string descricao = this.jogo.descricao;
            string imagemUrl = this.jogo.imagemUrl;
            string nome = this.jogo.nome;
            //int? AvaliaçãoId = null;
            //int? ComentarioId = null; 
            DAL.DALGames daljogo = new DAL.DALGames();
            Modelo.Jogo jogo = new Modelo.Jogo(JogoUrl, descricao, imagemUrl, nome);
            DAL.DALGames.Delete(jogo);
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

        protected void Sair()
        {
            if (Request.QueryString["exit"] != null)
            {
                Session.Contents.RemoveAll();
            }
        }

        #region"pegarAvaliacao"
        protected void pegarAvaliacao()
        {
            if (!Page.IsPostBack)
            {
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
        #endregion

        #region"estrelas"
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
            DAL.DALGames daljogo = new DAL.DALGames();
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

#endregion
    }
}