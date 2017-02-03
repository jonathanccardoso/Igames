using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq; 
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Public
{
    public partial class Busca : System.Web.UI.Page
    {
        public List<Modelo.Jogo> jogos { get { return Metodos.getBuscaJogo(Request.Form["search"]); } }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}