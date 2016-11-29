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
        public List<Modelo.Jogo> SelectAll()
        {
            Modelo.Jogo jogo;
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
        public Modelo.Jogo Select(int? jogo_id)
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
        public Modelo.Jogo SelectByName(string jogo_nome)
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

        //Método Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Jogo jogo)
        {
            try
            {
                if (this.Select(jogo.id) == null)
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
                    this.Update(jogo);
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Jogo jogo)
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
        public void Delete(Modelo.Jogo jogo)
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