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
        public List<Modelo.Favorito> SelectAll()
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
 
         //Método SelectByUser
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Favorito SelectByUser(string Usuario_id)
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
                    cmdFavorito.Parameters.AddWithValue("@Usuario_id", favorito.Usuario_id); 
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
        public Modelo.Favorito SelectByGame(int Jogo_id)
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
                    cmdFavorito.Parameters.AddWithValue("@Jogo_id", favorito.Jogo_id);
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
        public void Insert(Modelo.Favorito favorito)
        {
            try
            {
                if (this.SelectByUser(favorito.Usuario_id) == null && this.SelectByGame(favorito.Jogo_id) == null)
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
    }
}