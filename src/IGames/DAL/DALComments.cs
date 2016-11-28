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
        public DALComments() : base() { }

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
                                string descricaoComentario = (string)drComentarios["descricao"];
                                int idJogo = (int)drComentarios["Jogo_id"];
                                string idUsuario = (string)drComentarios["usuarioId"];

                                comentario = new Modelo.Comentario(descricaoComentario, idJogo, idUsuario);
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
        public Modelo.Comentario Select(int jogo_id, string usuario_id)
        {
            Modelo.Comentario Comentario = null;
            try
            {
                using (connection)
                {
                    connection.Open();
                    string sqlComentario = "SELECT * FROM Comentario WHERE Jogo_id = @jogo_id and Usuario_id = @usuario_id";
                    SqlCommand cmdComentario = new SqlCommand(sqlComentario, connection);
                    cmdComentario.Parameters.AddWithValue("@jogo_id", jogo_id);
                    cmdComentario.Parameters.AddWithValue("@usuario_id", usuario_id);
                    SqlDataReader drComentarios;

                    using (drComentarios = cmdComentario.ExecuteReader())
                    {
                        if (drComentarios.HasRows)
                        {
                            while (drComentarios.Read())
                            {
                                string descricao = (string)drComentarios["descricao"];
                                int idJogo = (int)drComentarios["Jogo_id"];
                                string UsuarioId = (string)drComentarios["usuarioId"];
                                Comentario = new Modelo.Comentario(descricao, idJogo, UsuarioId);
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
                if (this.Select(comentario.Jogo_id, comentario.Usuario_id) == null)
                {
                    using (connection)
                    {
                        connection.Open();
                        string sqlComentario = "INSERT INTO Comentario(descricao, usuarioId) VALUES (@descricao, @usuarioId)";
                        SqlCommand cmdComentario = new SqlCommand(sqlComentario, connection);
                        cmdComentario.Parameters.AddWithValue("@descricao", comentario.descricao);
                        cmdComentario.Parameters.AddWithValue("@usuarioId", SqlDbType.UniqueIdentifier).Value = comentario.Usuario_id;
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
                    if (Select(comentario.Jogo_id, comentario.Usuario_id) != comentario)
                    {
                        string sqlComentario = "UPDATE Comentario SET descricao = @descricao WHERE Jogo_id = @jogo_id and Usuario_id = @usuario_id";
                        SqlCommand cmdComentario = new SqlCommand(sqlComentario, connection);
                        cmdComentario.Parameters.AddWithValue("@descricao", comentario.descricao);
                        cmdComentario.Parameters.AddWithValue("@jogo_id", comentario.Jogo_id);
                        cmdComentario.Parameters.AddWithValue("@usuario_id", comentario.Usuario_id);
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
                    string sqlComentario = "DELETE FROM Comentario WHERE Jogo_id = @jogo_id and Usuario_id = @usuario_id";
                    SqlCommand cmdComentario = new SqlCommand(sqlComentario, connection);
                    cmdComentario.Parameters.AddWithValue("@jogo_id", comentario.Jogo_id);
                    cmdComentario.Parameters.AddWithValue("@usuario_id", comentario.Usuario_id);
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