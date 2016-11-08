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
        public DALUsers() : base() {}

        //Método SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Usuario> SelectAll()
        {
            Modelo.Usuario usuario;
            List<Modelo.Usuario> usuarios = new List<Modelo.Usuario>();

            try
            {
                using (connection)
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
                                string Username = (string)drUsuarios["UserName"];
                                string email = (string)drUsuarios["email"];
                                string iconeUrl = (string)drUsuarios["iconeUrl"]; 
                                int administrador = (int)drUsuarios["administrador"];
                                string idUsuario = (string)drUsuarios["usuarioId"];
                                 

                                usuario = new Modelo.Usuario(idUsuario, Username, email, iconeUrl, administrador);
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
                 using (connection)
                 {
                     //abre a conexão
                     connection.Open();
                     string sqlUsuario = "SELECT * FROM Usuario WHERE Usuario_id = @id";
                     SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, connection);
                     cmdUsuario.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = usuario_id;
                     SqlDataReader drCarrinhos;
                     using (drCarrinhos = cmdUsuario.ExecuteReader())
                     {
                         if (drCarrinhos.HasRows)
                         {
                             //lê os resultados
                             while (drCarrinhos.Read())
                             {
                                 string usuarioId = drCarrinhos["id"].ToString(); 
                                 string UserName = drCarrinhos["UserName"].ToString();
                                 string Email = drCarrinhos["email"].ToString();
                                 string iconeUrl = drCarrinhos["iconeUrl"].ToString();
                                 int adm = int.Parse(drCarrinhos["administrador"].ToString());
                                 usuario = new Modelo.Usuario(usuarioId, UserName, Email, iconeUrl, adm);
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
                if (this.Select(usuario.Id) == null)
                {
                    using (connection)
                        {
                            connection.Open();
                            string sqlUsuario = "INSERT INTO Usuario(UserName, email, iconeUrl, administrador, id) VALUES (@userName, @email, @iconeUrl, @administrador, @id)";
                            SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, connection);
                            cmdUsuario.Parameters.AddWithValue("@userName", usuario.UserName);
                            cmdUsuario.Parameters.AddWithValue("@email", usuario.Email);
                            cmdUsuario.Parameters.AddWithValue("@iconeUrl", usuario.IconeUrl);
                            cmdUsuario.Parameters.AddWithValue("@administrador", usuario.Adm); 
                            cmdUsuario.Parameters.AddWithValue("@id", usuario.Id);
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
                using (connection)
                {
                    connection.Open();
                    if (Select(usuario.Id) != usuario)
                    {
                        string sqlUsuario = "UPDATE Usuario SET Username = @Username, email = @email, iconeUrl = @iconeUrl WHERE id = @id";
                        SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, connection);
                        cmdUsuario.Parameters.AddWithValue("@Username", usuario.UserName);
                        cmdUsuario.Parameters.AddWithValue("@email", usuario.Email);
                        cmdUsuario.Parameters.AddWithValue("@iconeUrl", usuario.IconeUrl);                       
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
                using (connection)
                {
                    connection.Open();
                    string sqlUsuario = "DELETE FROM Usuario WHERE id = @id";
                    SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, connection);
                    cmdUsuario.Parameters.AddWithValue("@id", usuario.Id);
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