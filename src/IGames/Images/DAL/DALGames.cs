using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DALGames : DAL
    {
        public DALGames() : base() { }

        //Método SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Modelo.Jogo> SelectAll()
        {
            Modelo.Jogo jogo = null;
            List<Modelo.Jogo> jogos = new List<Modelo.Jogo>();

            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlJogos = "SELECT * FROM Jogo";
                    SqlCommand cmdJogos = new SqlCommand(sqlJogos, connection);
                    SqlDataReader drJogos;

                    using (drJogos = cmdJogos.ExecuteReader())
                    {
                        if (drJogos.HasRows)
                        {
                            while (drJogos.Read())
                            {
                                int idJogo = (int)drJogos["id"];
                                string jogoUrl = (string)drJogos["jogoUrl"];
                                string descricao = (string)drJogos["descricao"];
                                string imagemUrl = (string)drJogos["imagemUrl"];
                                string nome = (string)drJogos["nome"];
                                jogo = new Modelo.Jogo(idJogo, jogoUrl, descricao, imagemUrl, nome);
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

        //Método SelectTop
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Modelo.Jogo> SelectTop()
        {
            Modelo.Jogo jogo;
            List<Modelo.Jogo> jogos = new List<Modelo.Jogo>();

            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlJogos = "exec sp_TopAvaliacoes";
                    SqlCommand cmdJogos = new SqlCommand(sqlJogos, connection);
                    SqlDataReader drJogos;

                    using (drJogos = cmdJogos.ExecuteReader())
                    {
                        if (drJogos.HasRows)
                        {
                            while (drJogos.Read())
                            {
                                jogo = Select(Convert.ToInt32(drJogos["Jogo_id"]));
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

        //Método SelectRandom
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Modelo.Jogo> SelectRandom()
        {
            Modelo.Jogo jogo;
            List<Modelo.Jogo> jogos = new List<Modelo.Jogo>();
            Random r = new Random();

            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlJogos = "Select Count(id) as id from Jogo";
                    SqlCommand cmdJogos = new SqlCommand(sqlJogos, connection);
                    SqlDataReader drJogos;

                    using (drJogos = cmdJogos.ExecuteReader())
                    {
                        if (drJogos.HasRows)
                        {
                            while (drJogos.Read())
                            {
                                for (int i = 0; i <= 3; i++)
                                {
                                    jogo = Select(r.Next(SelectMin(), SelectMax()));
                                    jogos.Add(jogo);
                                }
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

        //Método Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Modelo.Jogo Select(int jogo_id)
        {
            //instancia um novo usuario
            Modelo.Jogo jogo = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    //abre a conexão
                    connection.Open();
                    string sqlJogo = "SELECT * FROM Jogo WHERE id = @id";
                    SqlCommand cmdJogo = new SqlCommand(sqlJogo, connection);
                    cmdJogo.Parameters.AddWithValue("@id", jogo_id);
                    SqlDataReader drJogo;
                    using (drJogo = cmdJogo.ExecuteReader())
                    {
                        if (drJogo.HasRows)
                        {
                            //lê os resultados
                            while (drJogo.Read())
                            {
                                int idJogo = (int)drJogo["id"];
                                string jogoUrl = (string)drJogo["jogoUrl"];
                                string descricao = (string)drJogo["descricao"];
                                string imagemUrl = (string)drJogo["imagemUrl"];
                                string nome = (string)drJogo["nome"];
                                jogo = new Modelo.Jogo(idJogo, jogoUrl, descricao, imagemUrl, nome);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return jogo;
        }

        //Método Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Modelo.Jogo SelectByName(string jogo_nome)
        {
            //instancia um novo usuario
            Modelo.Jogo jogo = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    //abre a conexão
                    connection.Open();
                    string sqlJogo = "SELECT * FROM Jogo WHERE nome = @nome";
                    SqlCommand cmdJogo = new SqlCommand(sqlJogo, connection);
                    cmdJogo.Parameters.AddWithValue("@nome", jogo_nome);
                    SqlDataReader drJogo;
                    using (drJogo = cmdJogo.ExecuteReader())
                    {
                        if (drJogo.HasRows)
                        {
                            //lê os resultados
                            while (drJogo.Read())
                            {
                                int idJogo = (int)drJogo["id"];
                                string jogoUrl = (string)drJogo["jogoUrl"];
                                string descricao = (string)drJogo["descricao"];
                                string imagemUrl = (string)drJogo["imagemUrl"];
                                string nome = (string)drJogo["nome"];
                                jogo = new Modelo.Jogo(idJogo, jogoUrl, descricao, imagemUrl, nome);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return jogo;
        }

        //Método Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static int SelectMin()
        {
            //instancia um novo usuario
            int min = 0;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    //abre a conexão
                    connection.Open();
                    string sqlJogo = "SELECT MIN(id) as id FROM Jogo";
                    SqlCommand cmdJogo = new SqlCommand(sqlJogo, connection);
                    SqlDataReader drJogo;
                    using (drJogo = cmdJogo.ExecuteReader())
                    {
                        if (drJogo.HasRows)
                        {
                            //lê os resultados
                            while (drJogo.Read())
                            {
                                min = Convert.ToInt32(drJogo["id"]);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return min;
        }

        //Método Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static int SelectMax()
        {
            //instancia um novo usuario
            int max = 0;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    //abre a conexão
                    connection.Open();
                    string sqlJogo = "SELECT MIN(id) as id FROM Jogo";
                    SqlCommand cmdJogo = new SqlCommand(sqlJogo, connection);
                    SqlDataReader drJogo;
                    using (drJogo = cmdJogo.ExecuteReader())
                    {
                        if (drJogo.HasRows)
                        {
                            //lê os resultados
                            while (drJogo.Read())
                            {
                                max = Convert.ToInt32(drJogo["id"]);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return max;
        }

        //Método Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static void Insert(Modelo.Jogo jogo)
        {
            try
            {
                if (Select(jogo.id) == null)
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlJogo = "INSERT INTO Jogo(jogoUrl, descricao, imagemUrl, nome) VALUES (@jogoUrl, @descricao, @imagemUrl, @nome)";
                        SqlCommand cmdJogo = new SqlCommand(sqlJogo, connection);
                        cmdJogo.Parameters.AddWithValue("@jogoUrl", jogo.jogoUrl);
                        cmdJogo.Parameters.AddWithValue("@descricao", jogo.descricao);
                        cmdJogo.Parameters.AddWithValue("@imagemUrl", jogo.imagemUrl);
                        cmdJogo.Parameters.AddWithValue("@nome", jogo.nome);
                        cmdJogo.ExecuteNonQuery();
                    }
                }
                else
                {
                    Update(jogo);
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public static void Update(Modelo.Jogo jogo)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (Select(jogo.id) != jogo)
                    {
                        string sqlJogo = "UPDATE Carrinho SET descricao = @descricao, nome = @nome, imagemUrl = @imagemUrl WHERE id = @id";
                        SqlCommand cmdJogo = new SqlCommand(sqlJogo, connection);
                        cmdJogo.Parameters.AddWithValue("@descricao", jogo.descricao);
                        cmdJogo.Parameters.AddWithValue("@nome", jogo.nome);
                        cmdJogo.Parameters.AddWithValue("@imagemUrl", jogo.imagemUrl);
                        cmdJogo.Parameters.AddWithValue("@id", jogo.id);
                        cmdJogo.ExecuteNonQuery();
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Delete
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public static void Delete(Modelo.Jogo jogo)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlJogo = "DELETE FROM Jogo WHERE id = @id";
                    SqlCommand cmdJogo = new SqlCommand(sqlJogo, connection);
                    cmdJogo.Parameters.AddWithValue("@id", jogo.id);
                    cmdJogo.ExecuteNonQuery();
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }
    }
}