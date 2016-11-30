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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Confirmar_Click(object sender, EventArgs e)
        {
            string JogoUrl = "";//QUERYSTRING
            string descricao = "";
            string imagemUrl = "";
            string nome = "";
           //int? AvaliaçãoId = null;
           //int? ComentarioId = null;

            DAL.DALGames daljogo = new DAL.DALGames();
            Modelo.Jogo jogo = new Modelo.Jogo(JogoUrl, descricao, imagemUrl, nome);
            daljogo.Delete(jogo);
        }
    }
}