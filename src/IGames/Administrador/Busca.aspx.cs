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
    public partial class Busca : System.Web.UI.Page
    {
        public Modelo.Jogo jog { get; set; }

        public DAL.DALGames daljogo { get; set; }

        public List<Modelo.Jogo> jogos { get; set; }

        public DAL.DALCategories dalcat { get; set; }

        public Modelo.Categoria categoria { get; set; }

        public List<Modelo.Categoria> categorias { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            getPesquisaJog();
            getPesquisaCat();
        }

        protected void getPesquisaJog()
        {
            if (!Page.IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["iGamesConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string a = Request.Form["search"];
                string sqlBusca = "SELECT * FROM dbo.fn_Busca (" + a + ")";
                SqlCommand cmdBusca = new SqlCommand(sqlBusca, connection);
                SqlDataReader drBusca = cmdBusca.ExecuteReader();
                if (drBusca.HasRows)
                {
                    while (drBusca.Read())
                    {
                        daljogo = new DAL.DALGames();
                        string nome = (string)drBusca["nome"];
                        jog = DAL.DALGames.SelectByName(nome);
                        jogos.Add(jog);
                    }
                }
                connection.Close();
            }
        }
        protected void getPesquisaCat()
        {
            if (!Page.IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["iGamesConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string a = Request.Form["search"];
                string sqlBusca = "SELECT * FROM dbo.fn_BuscaCat (" + a + ")";
                SqlCommand cmdBusca = new SqlCommand(sqlBusca, connection);
                SqlDataReader drBusca = cmdBusca.ExecuteReader();
                if (drBusca.HasRows)
                {
                    while (drBusca.Read())
                    {
                        string descricao = (string)drBusca["descricao"];
                        categoria = DAL.DALCategories.SelectByDescription(descricao);
                        categorias.Add(categoria);
                    }
                }
                connection.Close();
            }
        }
    }
}