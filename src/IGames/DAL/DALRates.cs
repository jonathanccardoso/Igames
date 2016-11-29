using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DALRates : DAL
    {
        public DALRates() : base() { }

        //Método SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Avaliacao> SelectAll()
        {
            Modelo.Avaliacao avaliacao;
            List<Modelo.Avaliacao> avaliacoes = new List<Modelo.Avaliacao>();

            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlAvaliacoes = "SELECT * FROM Avaliacao";
                    SqlCommand cmdAvaliacoes = new SqlCommand(sqlAvaliacoes, connection);
                    SqlDataReader drAvaliacoes;

                    using (drAvaliacoes = cmdAvaliacoes.ExecuteReader())
                    {
                        if (drAvaliacoes.HasRows)
                        {
                            while (drAvaliacoes.Read())
                            {
                                int idAvaliacao = (int)drAvaliacoes["id"];
                                int NumeroEstrelas = (int)drAvaliacoes["numeroEstrelas"];
                                string UsuarioId = (string)drAvaliacoes["usuarioId"];
                                avaliacao = new Modelo.Avaliacao(idAvaliacao, NumeroEstrelas, UsuarioId);
                                avaliacoes.Add(avaliacao);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }

            return avaliacoes;
        }

        //Método Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Avaliacao Select(int jogo_id, string usuario_id)
        {
            //instancia um novo usuario
            Modelo.Avaliacao avaliacao = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    //abre a conexão
                    connection.Open();
                    string sqlAvaliacao = "SELECT * FROM Avaliacao WHERE Usuario_id = @usuario_id and Jogo_id = @jogo_id";
                    SqlCommand cmdAvaliacao = new SqlCommand(sqlAvaliacao, connection);
                    cmdAvaliacao.Parameters.AddWithValue("@usuario_id", usuario_id);
                    cmdAvaliacao.Parameters.AddWithValue("@jogo_id", jogo_id);
                    SqlDataReader drAvaliacao;
                    using (drAvaliacao = cmdAvaliacao.ExecuteReader())
                    {
                        if (drAvaliacao.HasRows)
                        {
                            //lê os resultados
                            while (drAvaliacao.Read())
                            {
                                int idAvaliacao = (int)drAvaliacao["id"];
                                int NumeroEstrelas = (int)drAvaliacao["numeroEstrelas"];
                                string UsuarioId = (string)drAvaliacao["usuarioId"];
                                avaliacao = new Modelo.Avaliacao(idAvaliacao, NumeroEstrelas, UsuarioId);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return avaliacao;
        }

        //Método Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Avaliacao avaliacao)
        {
            try
            {
                if (this.Select(avaliacao.Jogo_id, avaliacao.Usuario_id) == null)
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlAvaliacao = "INSERT INTO Usuario(numeroEstrelas, UsuarioId) VALUES (@numeroEstrelas, @UsuarioId)";
                        SqlCommand cmdAvaliacao = new SqlCommand(sqlAvaliacao, connection);
                        cmdAvaliacao.Parameters.AddWithValue("@numeroEstrelas", avaliacao.numeroEstrelas);
                        cmdAvaliacao.Parameters.AddWithValue("@UsuarioId", avaliacao.Usuario_id);
                        cmdAvaliacao.ExecuteNonQuery();
                    }
                }
                else
                {
                    this.Update(avaliacao);
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Avaliacao avaliacao)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (Select(avaliacao.Jogo_id, avaliacao.Usuario_id) != avaliacao)
                    {
                        string sqlAvaliacao = "UPDATE Avaliação SET numeroEstrelas = @numeroEstrelas WHERE Usuario_id = @usuario_id and Jogo_id = @jogo_id";
                        SqlCommand cmdAvaliacao = new SqlCommand(sqlAvaliacao, connection);
                        cmdAvaliacao.Parameters.AddWithValue("@numeroEstrelas", avaliacao.numeroEstrelas);
                        cmdAvaliacao.Parameters.AddWithValue("@usuario_id", avaliacao.Usuario_id);
                        cmdAvaliacao.Parameters.AddWithValue("@jogo_id", avaliacao.Jogo_id);
                        cmdAvaliacao.ExecuteNonQuery();
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
        public void Delete(Modelo.Avaliacao avaliacao)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlAvaliacao = "DELETE FROM Avaliação WHERE Usuario_id = @usuario_id";
                    SqlCommand cmdAvaliacao = new SqlCommand(sqlAvaliacao, connection);
                    cmdAvaliacao.Parameters.AddWithValue("@usuario_id", avaliacao.Usuario_id);
                    cmdAvaliacao.ExecuteNonQuery();
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }
    }
}