using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Public
{
    public partial class Categorias : System.Web.UI.Page
    {
        public List<Modelo.Categoria> cats { get; set; }

        public List<Modelo.Jogo> jogos { get; set; }

        public List<Modelo.JogoCategoria> jogoscategorias { get; set; }

        public DAL.DALCategories dalcat { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getJogos();
                getCategories();
                getJogosCategorias();
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

        protected Modelo.Jogo getJogo(int jogo_id) {
           return DAL.DALGames.Select(jogo_id);
        }

        protected void getJogosCategorias()
        {
            this.jogos = DAL.DALGames.SelectAll();
        }
    }
}