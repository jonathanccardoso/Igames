using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DALCategories : DAL
    {
        
        public DALCategories() : base() { }

        //Método SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Modelo.Categoria> SelectAll()
        {

            Modelo.Categoria categoria;
            List<Modelo.Categoria> categorias = new List<Modelo.Categoria>();
            
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlCategorias = "SELECT * FROM Categoria";
                    SqlCommand cmdCategorias = new SqlCommand(sqlCategorias, connection);
                    SqlDataReader drCategorias;

                    using (drCategorias = cmdCategorias.ExecuteReader())
                    {
                        if (drCategorias.HasRows)
                        {
                            while (drCategorias.Read())
                            {
                                int idCategoria = (int)drCategorias["id"];
                                string descricaoCategoria = (string)drCategorias["descricao"];

                                categoria = new Modelo.Categoria(idCategoria, descricaoCategoria);
                                categorias.Add(categoria);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return categorias;
        }
        //Método SelectAllByDescription
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Modelo.Categoria SelectByDescription(string descricao) 
        {
            Modelo.Categoria categoria = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    //abre a conexão
                    connection.Open();
                    string sqlCategoria = "SELECT * FROM Categoria WHERE descricao = @descricao";
                    SqlCommand cmdCategoria = new SqlCommand(sqlCategoria, connection);
                    cmdCategoria.Parameters.AddWithValue("@descricao", descricao);
                    SqlDataReader drCategoria;
                    using (drCategoria = cmdCategoria.ExecuteReader())
                    {
                        if (drCategoria.HasRows)
                        {
                            //lê os resultados
                            while (drCategoria.Read())
                            {
                                int id = (int)drCategoria["id"];
                                string catdescricao = (string)drCategoria["descricao"];
                                categoria = new Modelo.Categoria(id, catdescricao);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return categoria;
        }

        //Método Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Modelo.Categoria Select(int Categoria_id)
        {
            Modelo.Categoria categoria = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlCategoria = "SELECT * FROM Categoria WHERE id = @id";
                    SqlCommand cmdCategoria = new SqlCommand(sqlCategoria, connection);
                    cmdCategoria.Parameters.AddWithValue("@id", Categoria_id);
                    SqlDataReader drCategorias;

                    using (drCategorias = cmdCategoria.ExecuteReader())
                    {
                        if (drCategorias.HasRows)
                        {
                            while (drCategorias.Read())
                            {
                                int idCategoria = (int)drCategorias["id"];
                                string descricaoCategoria = (string)drCategorias["descricao"];

                                categoria = new Modelo.Categoria(idCategoria, descricaoCategoria);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return categoria;
        }

        //Método Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public static void Insert(Modelo.Categoria categoria)
        {
            try
            {
                if (Select(categoria.id) == null)
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlCategoria = "INSERT INTO Categoria(descricao) VALUES (@descricao)";
                        SqlCommand cmdCategoria = new SqlCommand(sqlCategoria, connection);
                        cmdCategoria.Parameters.AddWithValue("@descricao", categoria.descricao);
                        cmdCategoria.ExecuteNonQuery();
                    }
                }
                else
                {
                    Update(categoria);
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public static void Update(Modelo.Categoria categoria)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlCategoria = "UPDATE Categoria SET descricao = @descricao WHERE id = @id";
                    SqlCommand cmdCategoria = new SqlCommand(sqlCategoria, connection);
                    cmdCategoria.Parameters.AddWithValue("@id", categoria.id);
                    cmdCategoria.Parameters.AddWithValue("@descricao", categoria.descricao);
                    cmdCategoria.ExecuteNonQuery();
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Delete
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public static void Delete(Modelo.Categoria categoria)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlCategoria = "DELETE FROM Categoria WHERE id = @id";
                    SqlCommand cmdCategoria = new SqlCommand(sqlCategoria, connection);
                    cmdCategoria.Parameters.AddWithValue("@id", categoria.id);
                    cmdCategoria.ExecuteNonQuery();
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }
    }
}