using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DALGamesCategories : DAL
    {
        public DALGamesCategories() : base() { }

        //Método SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.JogoCategoria> SelectAll()
        {
            Modelo.JogoCategoria jogocategoria;
            List<Modelo.JogoCategoria> jogosCategorias = new List<Modelo.JogoCategoria>();
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlJogocategoria = "SELECT * FROM JogoCategoria";
                    SqlCommand cmdJogocategoria = new SqlCommand(sqlJogocategoria, connection);
                    SqlDataReader drJogocategoria;

                    using (drJogocategoria = cmdJogocategoria.ExecuteReader())
                    {
                        if (drJogocategoria.HasRows)
                        {
                            while (drJogocategoria.Read())
                            {
                                int idJogoCategoria = (int)drJogocategoria["Jogo_id"];
                                int categoriaJogoCategoria = (int)drJogocategoria["Categoria_id"];
                                 
                                jogocategoria = new Modelo.JogoCategoria(idJogoCategoria, categoriaJogoCategoria);
                                jogosCategorias.Add(jogocategoria); 
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return jogosCategorias;
        }

        //Método Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.JogoCategoria Select(int Jogo_id) 
        {
            Modelo.JogoCategoria JogoCategoria = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlJogoCategoria = "SELECT * FROM JogoCategoria WHERE Jogo_id = @Jogo_id";
                    SqlCommand cmdJogoCategoria = new SqlCommand(sqlJogoCategoria, connection);
                    cmdJogoCategoria.Parameters.AddWithValue("@Jogo_id", Jogo_id);
                    SqlDataReader drJogoCategoria;

                    using (drJogoCategoria = cmdJogoCategoria.ExecuteReader())
                    {
                        if (drJogoCategoria.HasRows)
                        {
                            while (drJogoCategoria.Read())
                            {
                                int idJogo = (int)drJogoCategoria["Jogo_id"];
                                int idCategoria = (int)drJogoCategoria["Categoria_id"];

                                JogoCategoria = new Modelo.JogoCategoria(idJogo, idCategoria);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return JogoCategoria;
        }

        //Método SelectByCategory
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Modelo.JogoCategoria SelectByCategory(int Categoria_id)
        {
            Modelo.JogoCategoria JogoCategoria = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlJogoCategoria = "SELECT * FROM JogoCategoria WHERE Categoria_id = @Categoria_id";
                    SqlCommand cmdJogoCategoria = new SqlCommand(sqlJogoCategoria, connection);
                    cmdJogoCategoria.Parameters.AddWithValue("@Categoria_id", Categoria_id);
                    SqlDataReader drJogoCategoria;

                    using (drJogoCategoria = cmdJogoCategoria.ExecuteReader())
                    {
                        if (drJogoCategoria.HasRows)
                        {
                            while (drJogoCategoria.Read())
                            {
                                int idJogo = (int)drJogoCategoria["Jogo_id"];
                                int idCategoria = (int)drJogoCategoria["Categoria_id"];

                                JogoCategoria = new Modelo.JogoCategoria(idJogo, idCategoria);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return JogoCategoria;
        }

        //Método Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.JogoCategoria JogoCategoria) 
        {
            try
            {
                if (this.Select(JogoCategoria.Jogo_id) == null)
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlJogoCategoria = "INSERT INTO JogoCategoria(Jogo_id, Categoria_id) VALUES (@Jogo_id, @Categoria_id)";
                        SqlCommand cmdJogoCategoria = new SqlCommand(sqlJogoCategoria, connection);
                        cmdJogoCategoria.Parameters.AddWithValue("@Jogo_id", JogoCategoria.Jogo_id);
                        cmdJogoCategoria.Parameters.AddWithValue("@Categoria_id", JogoCategoria.Categoria_id);
                        cmdJogoCategoria.ExecuteNonQuery();
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
        public void Delete(Modelo.JogoCategoria JogoCategoria)
        { 
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlJogoCategoria = "DELETE FROM JogoCategoria WHERE Jogo_id = @Jogo_id and Categoria_id = @Categoria_id";
                    SqlCommand cmdJogoCategoria = new SqlCommand(sqlJogoCategoria, connection);
                    cmdJogoCategoria.Parameters.AddWithValue("@Jogo_id", JogoCategoria.Jogo_id);
                    cmdJogoCategoria.Parameters.AddWithValue("@Categoria_id", JogoCategoria.Categoria_id);
                    cmdJogoCategoria.ExecuteNonQuery();
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }
    }
}