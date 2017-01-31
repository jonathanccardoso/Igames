using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DALBusca
    {
    //    protected void getPesquisaJog()
    //    {
    //        if (!Page.IsPostBack)
    //        {
    //            string connectionString = ConfigurationManager.ConnectionStrings["iGamesConnectionString"].ConnectionString;
    //            //string connectionString = ConfigurationManager.ConnectionStrings["2016TiiGrupo5ConnectionString"].ConnectionString;
    //            SqlConnection connection = new SqlConnection(connectionString);
    //            connection.Open();
    //            string a = Request.Form["search"];
    //            string sqlBusca = "SELECT * FROM dbo.fn_Busca (" + a + ")";
    //            SqlCommand cmdBusca = new SqlCommand(sqlBusca, connection);
    //            SqlDataReader drBusca = cmdBusca.ExecuteReader();
    //            if (drBusca.HasRows)
    //            {
    //                while (drBusca.Read())
    //                {
    //                    jogos = new List<Modelo.Jogo>();
    //                    string nome = (string)drBusca["nome"];
    //                    jog = DAL.DALGames.SelectByName(nome);
    //                    jogos.Add(jog);
    //                }
    //            }
    //            else
    //            {
    //                Response.Redirect("~/Public/Busca.aspx?");
    //            }
    //            connection.Close();
    //        }
    //    }
    //    protected void getPesquisaCat()
    //    {
    //        if (!Page.IsPostBack)
    //        {
    //            string connectionString = ConfigurationManager.ConnectionStrings["iGamesConnectionString"].ConnectionString;
    //            //string connectionString = ConfigurationManager.ConnectionStrings["2016TiiGrupo5ConnectionString"].ConnectionString;
    //            SqlConnection connection = new SqlConnection(connectionString);
    //            connection.Open();
    //            string a = Request.Form["search"];
    //            string sqlBusca = "SELECT * FROM dbo.fn_BuscaCat (" + a + ")";
    //            SqlCommand cmdBusca = new SqlCommand(sqlBusca, connection);
    //            SqlDataReader drBusca = cmdBusca.ExecuteReader();
    //            if (drBusca.HasRows)
    //            {
    //                while (drBusca.Read())
    //                {
    //                    string descricao = (string)drBusca["descricao"];
    //                    categoria = DAL.DALCategories.SelectByDescription(descricao);
    //                    categorias.Add(categoria);
    //                }
    //            }
    //            connection.Close();
    //        }
    //    }
    }
}