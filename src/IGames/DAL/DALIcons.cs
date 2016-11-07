using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DALIcons : DAL
    {
        public DALIcons() : base() {}

        //Método SelectAll
        /*[DataObjectMethod(DataObjectMethodType.Select)]
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
                                int idUsuario = Convert.ToInt32(drCarrinhos["Usuario_id"]);
                                double precoTotal = Convert.ToDouble(drCarrinhos["precoTotal"]);
                                List<Modelo.itemCarrinho> itensCarrinho;

                                DALItemCarrinho dalItemCarrinho = new DALItemCarrinho();
                                itensCarrinho = dalItemCarrinho.SelectFromCarrinho(idUsuario);

                                carrinho = new Modelo.Carrinho(itensCarrinho, precoTotal, idUsuario);
                                
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
        }*/

        //Método Select
        /*[DataObjectMethod(DataObjectMethodType.Select)]
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
                                 string UserName = drCarrinhos["UserName"].ToString();
                                 string Email = drCarrinhos["email"].ToString();
                                 string iconeUrl = drCarrinhos["iconeUrl"].ToString();
                                 int adm = int.Parse(drCarrinhos["administrador"].ToString());
                                 usuario = new Modelo.Usuario(UserName, Email, iconeUrl, adm, usuario_id);
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
         }*/

        //Método Insert
        /*[DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Usuario usuario)
        {
            try
            {
                if (this.Select(usuario.id) == null)
                {
                    using (connection)
                    {
                        connection.Open();
                        string sqlUsuario = "INSERT INTO Usuario(UserName, email, iconeUrl, administrador, id) VALUES (@userName, @email, @iconeUrl, @administrador, @id)";
                        SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, connection);
                        cmdUsuario.Parameters.AddWithValue("@userName", usuario.UserName);
                        cmdUsuario.Parameters.AddWithValue("@email", usuario.Email);
                        cmdUsuario.Parameters.AddWithValue("@iconeUrl", usuario.iconeUrl);
                        cmdUsuario.Parameters.AddWithValue("@administrador", usuario.Administrador);
                        cmdUsuario.Parameters.AddWithValue("@id", usuario.id);
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
        }*/

        //Método Update
        /*[DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Usuario usuario)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    if (Select(usuario.id) != usuario)
                    {
                        string sqlUsuario = "UPDATE Carrinho SET precoTotal = @preco WHERE Usuario_id = @id";
                        SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, connection);
                        //cmdCarrinho.Parameters.Add("@preco", SqlDbType.Decimal).Value = carrinho.precoTotal;
                        //cmdCarrinho.Parameters.Add("@id", SqlDbType.Int).Value = carrinho.Usuario_id;
                        cmdUsuario.ExecuteNonQuery();
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }*/

        //Método Delete
        /*[DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Usuario usuario)
        {
            int id = Convert.ToInt32(usuario.id);
            try
            {
                using (connection)
                {
                    connection.Open();
                    string sqlUsuario = "DELETE FROM Carrinho WHERE id = @id";
                    SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, connection);
                    //cmdUsuario.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmdUsuario.ExecuteNonQuery();
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }*/
    }
}