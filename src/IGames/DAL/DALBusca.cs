using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DALBusca : DAL
    {

        public DALBusca() : base() { }

        //Método SelectBusca
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Modelo.Jogo> SelectBusca(string busca)
        {
            
            Modelo.Jogo jogo;
            List<Modelo.Jogo> jogos = new List<Modelo.Jogo>();
            
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlBusca = "SELECT * FROM dbo.fn_Busca (" + busca + ")";
                    SqlCommand cmdBusca = new SqlCommand(sqlBusca, connection);
                    SqlDataReader drBusca;

                    using (drBusca = cmdBusca.ExecuteReader())
                    {
                        if (drBusca.HasRows)
                        {
                            while (drBusca.Read())
                            {
                                string nome = (string)drBusca["nome"];
                                jogo = DALGames.SelectByName(nome);
                                jogos.Add(jogo);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return jogos;
        }
    }
}