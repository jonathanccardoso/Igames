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
        public DALRates() : base() {}

        //Método SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Avaliacao> SelectAll()
        {
            Modelo.Avaliacao avaliacao;
            List<Modelo.Avaliacao> avaliacoes = new List<Modelo.Avaliacao>();

            try
            {
                using (connection)
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
         public Modelo.Avaliacao Select(int avaliacao_id)
         {
             //instancia um novo usuario
             Modelo.Avaliacao avaliacao = null;
             try
             {
                 using (connection)
                 {
                     //abre a conexão
                     connection.Open();
                     string sqlAvaliacao = "SELECT * FROM Usuario WHERE Usuario_id = @id";
                     SqlCommand cmdAvaliacao = new SqlCommand(sqlAvaliacao, connection);
                     cmdAvaliacao.Parameters.Add("@id", avaliacao_id);
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
                if (this.Select(avaliacao.Id) == null)
                {
                    using (connection)
                    {
                        connection.Open();
                        string sqlAvaliacao = "INSERT INTO Usuario(numeroEstrelas, UsuarioId) VALUES (@numeroEstrelas, @UsuarioId)";
                        SqlCommand cmdAvaliacao = new SqlCommand(sqlAvaliacao, connection);
                        cmdAvaliacao.Parameters.AddWithValue("@userName", usuario.UserName);
                        cmdAvaliacao.Parameters.AddWithValue("@email", usuario.Email);
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
                using (connection)
                {
                    connection.Open();
                    if (Select(avaliacao.Id) != avaliacao)
                    {
                        string sqlAvaliacao = "UPDATE Avaliação SET numeroEstrelas = @numeroEstrelas WHERE id = @id";
                        SqlCommand cmdAvaliacao = new SqlCommand(sqlAvaliacao, connection);
                        cmdAvaliacao.Parameters.Add("@numeroEstrelas", avaliacao.NumeroEstrelas);
                        cmdAvaliacao.Parameters.Add("@id", avaliacao.Id);
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
                using (connection)
                {
                    connection.Open();
                    string sqlAvaliacao = "DELETE FROM Avaliação WHERE id = @id";
                    SqlCommand cmdAvaliacao = new SqlCommand(sqlAvaliacao, connection);
                    cmdAvaliacao.Parameters.Add("@id", avaliacao.Id);
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