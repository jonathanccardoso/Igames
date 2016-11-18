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
                using (connection)
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
                                int tipo = (int)drJogos["tipo"];
                                jogo = new Modelo.Jogo(idJogo, jogoUrl, descricao, imagemUrl, nome, tipo);
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
        public Modelo.Jogo Select(int jogo_id)
        {
            //instancia um novo usuario
            Modelo.Jogo jogo = null;
            try
            {
                using (connection)
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
                                int tipo = (int)drJogo["tipo"];
                                jogo = new Modelo.Jogo(idJogo, jogoUrl, descricao, imagemUrl, nome, tipo);
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

        //Add method to get the last game
        [DataObjectMethod(DataObjectMethodType.Select)]
        public int? SelectLast()
        {
            int? idLast = null;
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand cmdJogo = new SqlCommand("SELECT LAST(id) FROM Jogo", connection);
                    SqlDataReader drJogo;
                    using (drJogo = cmdJogo.ExecuteReader())
                    {
                        if (drJogo.HasRows)
                        {
                            while (drJogo.Read())
                            {
                                idLast = (int)drJogo["id"];
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return idLast;
        }

        //Método Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Jogo jogo)
        {
            try
            {
                if (this.Select(jogo.Id) == null)
                {
                    using (connection)
                    {
                        connection.Open();
                        string sqlJogo = "INSERT INTO Jogo(jogoUrl, descricao, imagemUrl, nome, tipo, avaliacaoId, comentarioId) VALUES (@jogoUrl, @descricao, @imagemUrl, @nome, @tipo, @avaliacaoId, @comentarioId)";
                        SqlCommand cmdJogo = new SqlCommand(sqlJogo, connection);
                        cmdJogo.Parameters.AddWithValue("@jogoUrl", jogo.JogoUrl);
                        cmdJogo.Parameters.AddWithValue("@descricao", jogo.Descricao);
                        cmdJogo.Parameters.AddWithValue("@imagemUrl", jogo.ImagemUrl);
                        cmdJogo.Parameters.AddWithValue("@nome", jogo.Nome);
                        cmdJogo.Parameters.AddWithValue("@tipo", jogo.Tipo);
                        cmdJogo.Parameters.AddWithValue("@avaliacaoId", jogo.AvaliacaoId);
                        cmdJogo.Parameters.AddWithValue("@comentarioId", jogo.ComentarioId);
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
                using (connection)
                {
                    connection.Open();
                    if (Select(jogo.Id) != jogo)
                    {
                        string sqlJogo = "UPDATE Carrinho SET descricao = @descricao, nome = @nome, imagemUrl = @imagemUrl WHERE id = @id";
                        SqlCommand cmdJogo = new SqlCommand(sqlJogo, connection);
                        cmdJogo.Parameters.AddWithValue("@descricao", jogo.Descricao);
                        cmdJogo.Parameters.AddWithValue("@nome", jogo.Nome);
                        cmdJogo.Parameters.AddWithValue("@imagemUrl", jogo.ImagemUrl);
                        cmdJogo.Parameters.AddWithValue("@id", jogo.Id);
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
                using (connection)
                {
                    connection.Open();
                    string sqlJogo = "DELETE FROM Jogo WHERE id = @id";
                    SqlCommand cmdJogo = new SqlCommand(sqlJogo, connection);
                    cmdJogo.Parameters.AddWithValue("@id", jogo.Id);
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