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
        public static List<Modelo.Avaliacao> SelectAll()
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
                                int NumeroEstrelas = (int)drAvaliacoes["numeroEstrelas"];
                                string UsuarioId = (string)drAvaliacoes["Usuario_id"];
                                int JogoId = (int)drAvaliacoes["Jogo_id"];
                                avaliacao = new Modelo.Avaliacao(NumeroEstrelas, JogoId, UsuarioId);
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
        //Metodo SelectByUser
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Modelo.Avaliacao SelectByUser(string Usuario_id)
        { 
            Modelo.Avaliacao avaliacao = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlAvaliacoes = "SELECT * FROM Avaliacao where Usuario_id = @Usuario_id";
                    SqlCommand cmdAvaliacoes = new SqlCommand(sqlAvaliacoes, connection);
                    cmdAvaliacoes.Parameters.AddWithValue("@Usuario_id", Usuario_id);
                    SqlDataReader drAvaliacoes;

                    using (drAvaliacoes = cmdAvaliacoes.ExecuteReader())
                    {
                        if (drAvaliacoes.HasRows)
                        {
                            while (drAvaliacoes.Read())
                            {
                                int NumeroEstrelas = (int)drAvaliacoes["numeroEstrelas"];
                                string UsuarioId = drAvaliacoes["Usuario_id"].ToString();
                                int JogoId = (int)drAvaliacoes["Jogo_id"];
                                avaliacao = new Modelo.Avaliacao(NumeroEstrelas, JogoId ,UsuarioId);
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

        //Metodo SelectAllByUser
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Modelo.Avaliacao> SelectAllByUser(string Usuario_id) 
        {
            Modelo.Avaliacao avaliacao = null;
            List<Modelo.Avaliacao> avaliacoes = new List<Modelo.Avaliacao>();
            try
            { 
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlAvaliacoes = "SELECT * FROM Avaliacao where Usuario_id = @Usuario_id";
                    SqlCommand cmdAvaliacoes = new SqlCommand(sqlAvaliacoes, connection);
                    cmdAvaliacoes.Parameters.AddWithValue("@Usuario_id", Usuario_id);
                    SqlDataReader drAvaliacoes;

                    using (drAvaliacoes = cmdAvaliacoes.ExecuteReader())
                    {
                        if (drAvaliacoes.HasRows)
                        {
                            while (drAvaliacoes.Read())
                            {
                                int NumeroEstrelas = (int)drAvaliacoes["numeroEstrelas"];
                                string UsuarioId = drAvaliacoes["Usuario_id"].ToString();
                                int JogoId = (int)drAvaliacoes["Jogo_id"];
                                avaliacao = new Modelo.Avaliacao(NumeroEstrelas, JogoId, UsuarioId);
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

        //Metodo SelectAllByGame
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Modelo.Avaliacao> SelectAllByGame(int Jogo_id) 
        {
            Modelo.Avaliacao avaliacao = null;
            List<Modelo.Avaliacao> avaliacoes = new List<Modelo.Avaliacao>();
            try
            { 
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlAvaliacoes = "SELECT * FROM Avaliacao where Jogo_id = @Jogo_id";
                    SqlCommand cmdAvaliacoes = new SqlCommand(sqlAvaliacoes, connection);
                    cmdAvaliacoes.Parameters.AddWithValue("@Jogo_id", Jogo_id);
                    SqlDataReader drAvaliacoes;

                    using (drAvaliacoes = cmdAvaliacoes.ExecuteReader())
                    {
                        if (drAvaliacoes.HasRows)
                        {
                            while (drAvaliacoes.Read())
                            {
                                int NumeroEstrelas = (int)drAvaliacoes["numeroEstrelas"];
                                string UsuarioId = drAvaliacoes["Usuario_id"].ToString();
                                int JogoId = (int)drAvaliacoes["Jogo_id"];
                                avaliacao = new Modelo.Avaliacao(NumeroEstrelas, JogoId, UsuarioId);
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
        public static Modelo.Avaliacao Select(int jogo_id, string usuario_id)
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
                                int NumeroEstrelas = int.Parse(drAvaliacao["numeroEstrelas"].ToString());
                                int JogoId = int.Parse(drAvaliacao["Jogo_id"].ToString());
                                string UsuarioId = drAvaliacao["Usuario_id"].ToString();
                                avaliacao = new Modelo.Avaliacao(NumeroEstrelas, JogoId, UsuarioId);
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
        public static void Insert(Modelo.Avaliacao avaliacao)
        {
            try
            {
                if (Select(avaliacao.Jogo_id, avaliacao.Usuario_id) == null)
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlAvaliacao = "INSERT INTO Avaliacao(numeroEstrelas, Jogo_id, Usuario_id) VALUES (@numeroEstrelas,@Jogo_id, @Usuario_id)";
                        SqlCommand cmdAvaliacao = new SqlCommand(sqlAvaliacao, connection);
                        cmdAvaliacao.Parameters.AddWithValue("@numeroEstrelas", avaliacao.numeroEstrelas);
                        cmdAvaliacao.Parameters.AddWithValue("@Jogo_id", avaliacao.Jogo_id);
                        cmdAvaliacao.Parameters.AddWithValue("@Usuario_id", avaliacao.Usuario_id);
                        
                        cmdAvaliacao.ExecuteNonQuery();
                    }
                }
                else
                {
                    Update(avaliacao);
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public static void Update(Modelo.Avaliacao avaliacao)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (Select(avaliacao.Jogo_id, avaliacao.Usuario_id) != avaliacao)
                    {
                        string sqlAvaliacao = "UPDATE Avaliacao SET numeroEstrelas = @numeroEstrelas WHERE Usuario_id = @usuario_id and Jogo_id = @jogo_id";
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
        public static void Delete(Modelo.Avaliacao avaliacao)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlAvaliacao = "DELETE FROM Avaliacao WHERE Usuario_id = @usuario_id";
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