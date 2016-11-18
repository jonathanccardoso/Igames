using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DALForum : DAL
    {
        public DALForum() : base() { }

        //Método SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Forum> SelectAll()
        {
            Modelo.Forum forum;
            List<Modelo.Forum> foruns = new List<Modelo.Forum>();

            try
            {
                using (connection)
                {
                    connection.Open();
                    string sqlForuns = "SELECT * FROM Forum";
                    SqlCommand cmdForuns = new SqlCommand(sqlForuns, connection);
                    SqlDataReader drForuns;

                    using (drForuns = cmdForuns.ExecuteReader())
                    {
                        if (drForuns.HasRows)
                        {
                            while (drForuns.Read())
                            {
                                int idForum = (int)drForuns["id"];
                                string descricao = (string)drForuns["descricao"];
                                string data = (string)drForuns["data"];
                                string hora = (string)drForuns["hora"];
                                string usuarioId = (string)drForuns["Usuario_id"];
                                int idPostagem = (int)drForuns["Postagem_id"];
                                forum = new Modelo.Forum(idForum, descricao, data, hora, usuarioId, idPostagem);
                                foruns.Add(forum);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return foruns;
        }

        //Método Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Forum Select(int forum_id)
        {
            //instancia um novo Forum
            Modelo.Forum forum = null;
            try
            {
                using (connection)
                {
                    //abre a conexão
                    connection.Open();
                    string sqlForum = "SELECT * FROM Forum WHERE id = @id";
                    SqlCommand cmdForum = new SqlCommand(sqlForum, connection);
                    cmdForum.Parameters.AddWithValue("@id", forum_id);
                    SqlDataReader drForum;
                    using (drForum = cmdForum.ExecuteReader())
                    {
                        if (drForum.HasRows)
                        {
                            while (drForum.Read())
                            {
                                int idForum = (int)drForum["id"];
                                string descricao = (string)drForum["descricao"];
                                string data = (string)drForum["data"];
                                string hora = (string)drForum["hora"];
                                string usuarioId = (string)drForum["Usuario_id"];
                                int idPostagem = (int)drForum["Postagem_id"];
                                forum = new Modelo.Forum(idForum, descricao, data, hora, usuarioId, idPostagem);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return forum;
        }

        //Método Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Forum forum)
        {
            try
            {
                if (this.Select(forum.Id) == null)
                {
                    using (connection)
                    {
                        connection.Open();
                        string sqlforum = "INSERT INTO Forum(descricao, data, hora, Usuario_id, Postagem_id) VALUES (@descricao, @data, @hora, @usuarioId, @postagemId)";
                        SqlCommand cmdforum = new SqlCommand(sqlforum, connection);
                        cmdforum.Parameters.AddWithValue("@descricao", forum.Descricao);
                        cmdforum.Parameters.AddWithValue("@data", SqlDbType.Date).Value = forum.Data.ToString("yyyy-MM-dd");
                        cmdforum.Parameters.AddWithValue("@hora", forum.Hora);
                        cmdforum.Parameters.AddWithValue("@usuarioId", forum.UsuarioId);
                        cmdforum.Parameters.AddWithValue("@postagemId", forum.PostagemId);
                        cmdforum.ExecuteNonQuery();
                    }
                }
                else
                {
                    this.Update(forum);
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Forum forum)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    if (Select(forum.Id) != forum)
                    {
                        string sqlForum = "UPDATE Forum SET descricao = @descricao, data = @data, hora = @hora WHERE id = @id";
                        SqlCommand cmdForum = new SqlCommand(sqlForum, connection);
                        cmdForum.Parameters.AddWithValue("@descricao", forum.Descricao);
                        cmdForum.Parameters.AddWithValue("@data", forum.Data);
                        cmdForum.Parameters.AddWithValue("@hora", forum.Hora);
                        cmdForum.Parameters.AddWithValue("@id", forum.Id);
                        cmdForum.ExecuteNonQuery();
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
        public void Delete(Modelo.Forum forum)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    string sqlForum = "DELETE FROM Forum WHERE id = @id";
                    SqlCommand cmdForum = new SqlCommand(sqlForum, connection);
                    cmdForum.Parameters.AddWithValue("@id", forum.Id);
                    cmdForum.ExecuteNonQuery();
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }
    }
}