using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DALFavorites : DAL
    {
        public DALFavorites() : base() { }

        //Método SelectAll 
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Modelo.Favorito> SelectAll()
        {
            Modelo.Favorito favorito; 
            List<Modelo.Favorito> favoritos = new List<Modelo.Favorito>();
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlFavoritos = "SELECT * FROM Favorito";
                    SqlCommand cmdFavoritos = new SqlCommand(sqlFavoritos, connection);
                    SqlDataReader drFavoritos;   

                    using (drFavoritos = cmdFavoritos.ExecuteReader())
                    {
                        if (drFavoritos.HasRows)
                        {
                            while (drFavoritos.Read())
                            {
                                string Usuario_id = drFavoritos["Usuario_id"].ToString();
                                int Jogo_id = (int)drFavoritos["Jogo_id"];

                                favorito = new Modelo.Favorito(Usuario_id, Jogo_id);
                                favoritos.Add(favorito); 
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }

            return favoritos;
        }

        //Método SelectAllUser 
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Modelo.Favorito> SelectAllByUser(int Usuario_id)
        {
            Modelo.Favorito favorito; 
            List<Modelo.Favorito> favoritos = new List<Modelo.Favorito>();
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlFavoritos = "SELECT * FROM Favorito WHERE Usuario_id = @Usuario_id";
                    SqlCommand cmdFavoritos = new SqlCommand(sqlFavoritos, connection);
                    cmdFavorito.Parameters.AddWithValue("@Usuario_id", Usuario_id);
                    SqlDataReader drFavoritos;   

                    using (drFavoritos = cmdFavoritos.ExecuteReader())
                    {
                        if (drFavoritos.HasRows)
                        {
                            while (drFavoritos.Read())
                            {
                                string Usuario_id = drFavoritos["Usuario_id"].ToString();
                                int Jogo_id = (int)drFavoritos["Jogo_id"];

                                favorito = new Modelo.Favorito(Usuario_id, Jogo_id);
                                favoritos.Add(favorito); 
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }

            return favoritos;
        }

        //Método SelectAllByGame 
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Modelo.Favorito> SelectAllByGame(int Jogo_id)
        {
            Modelo.Favorito favorito; 
            List<Modelo.Favorito> favoritos = new List<Modelo.Favorito>();
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlFavoritos = "SELECT * FROM Favorito WHERE Jogo_id = @Jogo_id";
                    SqlCommand cmdFavoritos = new SqlCommand(sqlFavoritos, connection);
                    cmdFavorito.Parameters.AddWithValue("@Jogo_id", Jogo_id);
                    SqlDataReader drFavoritos;   

                    using (drFavoritos = cmdFavoritos.ExecuteReader())
                    {
                        if (drFavoritos.HasRows)
                        {
                            while (drFavoritos.Read())
                            {
                                string Usuario_id = drFavoritos["Usuario_id"].ToString();
                                int Jogo_id = (int)drFavoritos["Jogo_id"];

                                favorito = new Modelo.Favorito(Usuario_id, Jogo_id);
                                favoritos.Add(favorito); 
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }

            return favoritos;
        }
 
         //Método SelectByUser
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Modelo.Favorito SelectByUser(string Usuario_id)
        {
            //instancia um novo usuario
            Modelo.Favorito favorito = null; 
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    //abre a conexão
                    connection.Open();
                    string sqlFavorito = "SELECT * FROM Favorito WHERE Usuario_id = @Usuario_id"; 
                    SqlCommand cmdFavorito = new SqlCommand(sqlFavorito, connection);
                    cmdFavorito.Parameters.AddWithValue("@Usuario_id", Usuario_id); 
                    SqlDataReader drFavoritos; 
                    using (drFavoritos = cmdFavorito.ExecuteReader())
                    {
                        if (drFavoritos.HasRows)
                        {
                            //lê os resultados
                            while (drFavoritos.Read())
                            {
                                string idUsuario = drFavoritos["Usuario_id"].ToString();
                                int idJogo = (int)drFavoritos["Jogo_id"];
                                favorito = new Modelo.Favorito(idUsuario, idJogo); 
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            } 
            return favorito;
        }

        //Método SelectByGame
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Modelo.Favorito SelectByGame(int Jogo_id)
        {
            //instancia um novo usuario
            Modelo.Favorito favorito = null; 
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    //abre a conexão
                    connection.Open();
                    string sqlFavorito = "SELECT * FROM Favorito WHERE Jogo_id = @Jogo_id";
                    SqlCommand cmdFavorito = new SqlCommand(sqlFavorito, connection);
                    cmdFavorito.Parameters.AddWithValue("@Jogo_id", Jogo_id);
                    SqlDataReader drFavoritos;
                    using (drFavoritos = cmdFavorito.ExecuteReader())
                    {
                        if (drFavoritos.HasRows)
                        {
                            //lê os resultados
                            while (drFavoritos.Read())
                            {
                                string idUsuario = drFavoritos["Usuario_id"].ToString();
                                int idJogo = (int)drFavoritos["Jogo_id"];
                                favorito = new Modelo.Favorito(idUsuario, idJogo);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return favorito;
        }

         //Método Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static void Insert(Modelo.Favorito favorito)
        {
            try
            {
                if (SelectByUser(favorito.Usuario_id) == null && SelectByGame(favorito.Jogo_id) == null)
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlFavorito = "INSERT INTO Favorito(Usuario_id, Jogo_id) VALUES (@Usuario_id, @Jogo_id)";
                        SqlCommand cmdFavorito = new SqlCommand(sqlFavorito, connection);
                        cmdFavorito.Parameters.AddWithValue("@Usuario_id", favorito.Usuario_id);
                        cmdFavorito.Parameters.AddWithValue("@Jogo_id", favorito.Jogo_id);
                        cmdFavorito.ExecuteNonQuery();
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }
        
        //Método DeleteByUser
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public static void DeleteByUser(Modelo.Favorito favorito) 
        {
            try
            { 
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlFavorito = "DELETE from Favorito WHERE Usuario_id = @usuario_id";
                    SqlCommand cmdFavorito = new SqlCommand(sqlFavorito, connection);
                    cmdFavorito.Parameters.AddWithValue("@usuario_id", favorito.Usuario_id);
                    cmdFavorito.ExecuteNonQuery();
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }
    }
}