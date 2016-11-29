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
        public List<Modelo.Categoria> SelectAll()
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

        //Método Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Categoria Select(int Categoria_id)
        {
            Modelo.Categoria categoria = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlCategoria = "SELECT * FROM Categoria WHERE Categoria_id = @id";
                    SqlCommand cmdCategoria = new SqlCommand(sqlCategoria, connection);
                    cmdCategoria.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = Categoria_id;
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
        public void Insert(Modelo.Categoria categoria)
        {
            try
            {
                if (this.Select(categoria.id) == null)
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
                    this.Update(categoria);
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Categoria categoria)
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
        public void Delete(Modelo.Categoria categoria)
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