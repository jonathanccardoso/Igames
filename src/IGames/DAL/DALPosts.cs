using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DALPosts : DAL
    {
        public DALPosts() : base() {}

        //Método SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Postagem> SelectAll()
        {
            Modelo.Postagem postagem;
            List<Modelo.Postagem> postagens = new List<Modelo.Postagem>();

            try
            {
                using (connection)
                {
                    connection.Open();
                    string sqlPostagens = "SELECT * FROM Postagem";
                    SqlCommand cmdPostagens = new SqlCommand(sqlPostagens, connection);
                    SqlDataReader drPostagens;

                    using (drPostagens = cmdPostagens.ExecuteReader())
                    {
                        if (drPostagens.HasRows)
                        {
                            while (drPostagens.Read())
                            {
                                int idPostagem = (int)drPostagens["id"];
                                string Texto = (string)drPostagens["texto"];
                                string Data = (string)drPostagens["data"];
                                string Hora = (string)drPostagens["hora"];
                                string UsuarioId = (string)drPostagens["Usuario_id"];
                                int PostagemCitada = (int)drPostagens["PostagemCitada"];
                                int idForum = (int)drPostagens["Forum_id"];
                                postagem = new Modelo.Postagem(idPostagem, Texto, Data, Hora, UsuarioId, PostagemCitada, idForum);
                                postagens.Add(postagem);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }

            return postagens;
        }

        //Método Select
        [DataObjectMethod(DataObjectMethodType.Select)]
         public Modelo.Postagem Select(int postagem_id)
         {
             //instancia um novo postagem
             Modelo.Postagem postagem = null;
             try
             {
                 using (connection)
                 {
                     //abre a conexão
                     connection.Open();
                     string sqlPostagem = "SELECT * FROM Postagem WHERE id = @id";
                     SqlCommand cmdPostagem = new SqlCommand(sqlPostagem, connection);
                     cmdPostagem.Parameters.AddWithValue("@id", postagem_id);
                     SqlDataReader drPostagem;
                     using (drPostagem = cmdPostagem.ExecuteReader())
                     {
                         if (drPostagem.HasRows)
                         {
                             //lê os resultados
                             while (drPostagem.Read())
                             {
                                 int idPostagem = (int)drPostagem["id"];
                                 string Texto = (string)drPostagem["texto"];
                                 string Data = (string)drPostagem["data"];
                                 string Hora = (string)drPostagem["hora"];
                                 string UsuarioId = (string)drPostagem["Usuario_id"];
                                 int PostagemCitada = (int)drPostagem["PostagemCitada"];
                                 int idForum = (int)drPostagem["Forum_id"];
                                 postagem = new Modelo.Postagem(idPostagem, Texto, Data, Hora, UsuarioId, PostagemCitada, idForum);
                             }
                         }
                     }
                 }
             }
             catch (SystemException)
             {
                 throw;
             }
             return postagem;
         }

        //Método Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Postagem postagem)
        {
            try
            {
                if (this.Select(postagem.Id) == null)
                {
                    using (connection)
                    {
                        connection.Open();
                        string sqlPostagem = "INSERT INTO Postagem(texto, data, hora, Usuario_id, PostagemCitada, Forum_id) VALUES (@texto, @data, @hora, @UsuarioId, @PostagemCitada, @ForumId)";
                        SqlCommand cmdPostagem = new SqlCommand(sqlPostagem, connection);
                        cmdPostagem.Parameters.AddWithValue("@texto", postagem.Texto);
                        cmdPostagem.Parameters.AddWithValue("@data", postagem.Data);
                        cmdPostagem.Parameters.AddWithValue("@hora", postagem.Hora);
                        cmdPostagem.Parameters.AddWithValue("@UsuarioId", postagem.UsuarioId);
                        cmdPostagem.Parameters.AddWithValue("@PostagemCitada", postagem.PostagemCitada);
                        cmdPostagem.Parameters.AddWithValue("@ForumId", postagem.ForumId);
                        cmdPostagem.ExecuteNonQuery();
                    }
                }
                else
                {
                    this.Update(postagem);
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Postagem postagem)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    if (Select(postagem.Id) != postagem)
                    {
                        string sqlPostagem = "UPDATE Carrinho SET texto = @texto WHERE id = @id";
                        SqlCommand cmdPostagem = new SqlCommand(sqlPostagem, connection);
                        cmdPostagem.Parameters.AddWithValue("@texto", postagem.Texto);
                        cmdPostagem.Parameters.AddWithValue("@id", postagem.Id);
                        cmdPostagem.ExecuteNonQuery();
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
        public void Delete(Modelo.Postagem postagem)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    string sqlPostagem = "DELETE FROM Postagem WHERE id = @id";
                    SqlCommand cmdPostagem = new SqlCommand(sqlPostagem, connection);
                    cmdPostagem.Parameters.AddWithValue("@id", postagem.Id);
                    cmdPostagem.ExecuteNonQuery();
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }
    }
}