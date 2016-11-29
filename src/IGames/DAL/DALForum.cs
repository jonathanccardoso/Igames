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
                using (connection = new SqlConnection(connectionString))
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
                                forum = new Modelo.Forum(idForum, descricao, data, hora, usuarioId);
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
                using (connection = new SqlConnection(connectionString))
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
                                forum = new Modelo.Forum(idForum, descricao, data, hora, usuarioId);
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
                if (this.Select(forum.id) == null)
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlforum = "INSERT INTO Forum(descricao, data, hora, Usuario_id) VALUES (@descricao, @data, @hora, @usuarioId)";
                        SqlCommand cmdforum = new SqlCommand(sqlforum, connection);
                        cmdforum.Parameters.AddWithValue("@descricao", forum.descricao);
                        cmdforum.Parameters.AddWithValue("@data", SqlDbType.Date).Value = forum.data.ToString("yyyy-MM-dd");
                        cmdforum.Parameters.AddWithValue("@hora", forum.hora);
                        cmdforum.Parameters.AddWithValue("@usuarioId", forum.Usuario_id);
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
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (Select(forum.id) != forum)
                    {
                        string sqlForum = "UPDATE Forum SET descricao = @descricao, data = @data, hora = @hora WHERE id = @id";
                        SqlCommand cmdForum = new SqlCommand(sqlForum, connection);
                        cmdForum.Parameters.AddWithValue("@descricao", forum.descricao);
                        cmdForum.Parameters.AddWithValue("@data", forum.data);
                        cmdForum.Parameters.AddWithValue("@hora", forum.hora);
                        cmdForum.Parameters.AddWithValue("@id", forum.id);
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
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlForum = "DELETE FROM Forum WHERE id = @id";
                    SqlCommand cmdForum = new SqlCommand(sqlForum, connection);
                    cmdForum.Parameters.AddWithValue("@id", forum.id);
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