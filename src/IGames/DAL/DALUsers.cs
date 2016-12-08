using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DALUsers : DAL
    {
        public DALUsers() : base() { }

        //Método SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Usuario> SelectAll()
        {
            Modelo.Usuario usuario;
            List<Modelo.Usuario> usuarios = new List<Modelo.Usuario>();

            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlUsuarios = "SELECT * FROM Usuario";
                    SqlCommand cmdUsuarios = new SqlCommand(sqlUsuarios, connection);
                    SqlDataReader drUsuarios;

                    using (drUsuarios = cmdUsuarios.ExecuteReader())
                    {
                        if (drUsuarios.HasRows)
                        {
                            while (drUsuarios.Read())
                            {
                                string idUsuario = Convert.ToString(drUsuarios["id"]);
                                string Username = (string)drUsuarios["nome"];
                                string email = (string)drUsuarios["email"];
                                string senha = (string)drUsuarios["senha"];
                                bool administrador = (bool)drUsuarios["administrador"];
                                int iconeId = (int)drUsuarios["Icone_id"];
                                usuario = new Modelo.Usuario(idUsuario, Username, email, senha, administrador, iconeId);
                                usuarios.Add(usuario);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }

            return usuarios;
        }

        //Método Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Usuario Select(string usuario_id)
        {
            //instancia um novo usuario
            Modelo.Usuario usuario = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    //abre a conexão
                    connection.Open();
                    string sqlUsuario = "SELECT * FROM Usuario WHERE id = @id";
                    SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, connection);
                    cmdUsuario.Parameters.AddWithValue("@id", usuario_id);
                    SqlDataReader drUsuarios;
                    using (drUsuarios = cmdUsuario.ExecuteReader())
                    {
                        if (drUsuarios.HasRows)
                        {
                            while (drUsuarios.Read())
                            {
                                string usuarioId = drUsuarios["id"].ToString();
                                string UserName = drUsuarios["nome"].ToString();
                                string Email = drUsuarios["email"].ToString();
                                string Senha = drUsuarios["senha"].ToString();
                                int idIcone = (int)drUsuarios["Icone_id"];
                                bool adm = (bool)drUsuarios["administrador"];
                                usuario = new Modelo.Usuario(usuarioId, UserName, Email, Senha, adm, idIcone);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return usuario;
        }

        //Método Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Usuario usuario)
        {
            try
            {
                if (this.Select(usuario.id) == null)
                {
                    using (connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlUsuario = "INSERT INTO Usuario(id, nome, email, senha, icone_id, administrador) VALUES (@id, @userName, @email, @senha, @icone_id, @administrador)";
                        SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, connection);
                        cmdUsuario.Parameters.AddWithValue("@id", usuario.id);
                        cmdUsuario.Parameters.AddWithValue("@userName", usuario.nome);
                        cmdUsuario.Parameters.AddWithValue("@email", usuario.email);
                        cmdUsuario.Parameters.AddWithValue("@senha", usuario.senha);
                        cmdUsuario.Parameters.AddWithValue("@icone_id", usuario.Icone_id);
                        cmdUsuario.Parameters.AddWithValue("@administrador", usuario.administrador);
                        cmdUsuario.ExecuteNonQuery();
                    }
                }
                else
                {
                    this.Update(usuario);
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Usuario usuario)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (Select(usuario.id) != usuario)
                    {
                        string sqlUsuario = "UPDATE Usuario SET Username = @Username, email = @email, iconeUrl = @iconeUrl WHERE id = @id";
                        SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, connection);
                        cmdUsuario.Parameters.AddWithValue("@Username", usuario.nome);
                        cmdUsuario.Parameters.AddWithValue("@email", usuario.email);
                        cmdUsuario.Parameters.AddWithValue("@iconeUrl", usuario.Icone_id);
                        cmdUsuario.ExecuteNonQuery();
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
        public void Delete(Modelo.Usuario usuario)
        {
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlUsuario = "DELETE FROM Usuario WHERE id = @id";
                    SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, connection);
                    cmdUsuario.Parameters.AddWithValue("@id", usuario.id);
                    cmdUsuario.ExecuteNonQuery();
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }
    }
}