using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DALComments : DAL
    {
        public DALComments() : base() {}

        //Método SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Comentario> SelectAll()
        {
            Modelo.Comentario comentario;
            List<Modelo.Comentario> comentarios = new List<Modelo.Comentario>();

            try
            {
                using (connection)
                {
                    connection.Open();
                    string sqlComentarios = "SELECT * FROM Comentario";
                    SqlCommand cmdComentarios = new SqlCommand(sqlComentarios, connection);
                    SqlDataReader drComentarios;

                    using (drComentarios = cmdComentarios.ExecuteReader())
                    {
                        if (drComentarios.HasRows)
                        {
                            while (drComentarios.Read())
                            {
                                int idComentario = (int)drComentarios["id"];
                                string descricaoComentario = (string)drComentarios["descricao"];
                                string idUsuario = (string)drComentarios["usuarioId"];

                                comentario = new Modelo.Comentario(idComentario, descricaoComentario, idUsuario);
                                comentarios.Add(comentario);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return comentarios;
        }

        //Método Select
        [DataObjectMethod(DataObjectMethodType.Select)]
         public Modelo.Comentario Select(int Comentario_id)
         {
             Modelo.Comentario Comentario = null;
             try
             {
                 using (connection)
                 {
                     connection.Open();
                     string sqlComentario = "SELECT * FROM Comentario WHERE Comentario_id = @id";
                     SqlCommand cmdComentario = new SqlCommand(sqlComentario, connection);
                     cmdComentario.Parameters.Add("@id", Comentario_id);
                     SqlDataReader drComentarios;

                     using (drComentarios = cmdComentario.ExecuteReader())
                     {
                         if (drComentarios.HasRows)
                         {
                             while (drComentarios.Read())
                             {
                                 int idComentario = (int)drComentarios["id"];
                                 string descricao = (string)drComentarios["descricao"];
                                 string UsuarioId = (string)drComentarios["usuarioId"];

                                 Comentario = new Modelo.Comentario(idComentario, descricao, UsuarioId);
                             }
                         }
                     }
                 }
             }
             catch (SystemException)
             {
                 throw;
             }
             return Comentario;
         }

        //Método Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Comentario comentario)
        {
            try
            {
                if (this.Select(comentario.Id) == null)
                {
                    using (connection)
                    {
                        connection.Open();
                        string sqlComentario = "INSERT INTO Comentario(descricao, usuarioId) VALUES (@descricao, @usuarioId)";
                        SqlCommand cmdComentario = new SqlCommand(sqlComentario, connection);
                        cmdComentario.Parameters.Add("@descricao", comentario.Descricao);
                        cmdComentario.Parameters.Add("@usuarioId", SqlDbType.UniqueIdentifier).Value = comentario.UsuarioId;
                        cmdComentario.ExecuteNonQuery();
                    }
                }
                else
                {
                    this.Update(comentario);
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Comentario comentario)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    if (Select(comentario.Id) != comentario)
                    {
                        string sqlComentario = "UPDATE Comentario SET descricao = @descricao WHERE id = @id";
                        SqlCommand cmdComentario = new SqlCommand(sqlComentario, connection);
                        cmdComentario.Parameters.Add("@descricao", comentario.Descricao);
                        cmdComentario.Parameters.Add("@id", comentario.Id);
                        cmdComentario.ExecuteNonQuery();
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
        public void Delete(Modelo.Comentario comentario)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    string sqlComentario = "DELETE FROM Comentario WHERE id = @id";
                    SqlCommand cmdComentario = new SqlCommand(sqlComentario, connection);
                    cmdComentario.Parameters.Add("@id", comentario.Id);
                    cmdComentario.ExecuteNonQuery();
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }
    }
}