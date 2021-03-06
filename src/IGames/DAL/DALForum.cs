﻿using System;
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
        public static List<Modelo.Forum> SelectAll()
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
                                int idForum = Convert.ToInt32(drForuns["id"]);
                                string descricao = Convert.ToString(drForuns["descricao"]);
                                string data = Convert.ToString(drForuns["data"]);
                                string hora = Convert.ToString(drForuns["hora"]);
                                string usuarioId = Convert.ToString(drForuns["Usuario_id"]);
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

        //Método SelectAllByUser
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<Modelo.Forum> SelectAllByUser(string Usuario_id)
        {
            Modelo.Forum forum;
            List<Modelo.Forum> foruns = new List<Modelo.Forum>();

            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlForuns = "SELECT * FROM Forum WHERE Usuario_id = @Usuario_id";
                    SqlCommand cmdForuns = new SqlCommand(sqlForuns, connection);
                    cmdForum.Parameters.AddWithValue("@Usuario_id", Usuario_id);
                    SqlDataReader drForuns;

                    using (drForuns = cmdForuns.ExecuteReader())
                    {
                        if (drForuns.HasRows)
                        {
                            while (drForuns.Read())
                            {
                                int idForum = Convert.ToInt32(drForuns["id"]);
                                string descricao = Convert.ToString(drForuns["descricao"]);
                                string data = Convert.ToString(drForuns["data"]);
                                string hora = Convert.ToString(drForuns["hora"]);
                                string usuarioId = Convert.ToString(drForuns["Usuario_id"]);
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
        public static Modelo.Forum Select(int forum_id)
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
        public static void Insert(Modelo.Forum forum)
        {
            try
            {
                if (Select(forum.id) == null)
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlforum = "INSERT INTO Forum(descricao, data, hora, Usuario_id) VALUES (@descricao, @data, @hora, @usuarioId)";
                        SqlCommand cmdforum = new SqlCommand(sqlforum, connection);
                        cmdforum.Parameters.AddWithValue("@descricao", forum.descricao);
                        cmdforum.Parameters.AddWithValue("@data", SqlDbType.Date).Value = forum.data;
                        cmdforum.Parameters.AddWithValue("@hora", forum.hora);
                        cmdforum.Parameters.AddWithValue("@usuarioId", forum.Usuario_id);
                        cmdforum.ExecuteNonQuery();
                    }
                }
                else
                {
                    Update(forum);
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public static void Update(Modelo.Forum forum)
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
        public static void Delete(Modelo.Forum forum)
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