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

        public List<Modelo.Jogo> destaque { get; set; }

        public List<Modelo.Jogo> recomendado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
//            getRecomendado();

        }
        //protected void getRecomendado()
        //{
        //    if (!Page.IsPostBack)
        //    {
        //        this.destaque = DAL.DALGames.SelectRandom();
        //    }
        //}
    }
}