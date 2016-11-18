using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IGames.DAL
{
    public class DALIcons : DAL
    {
        public DALIcons() : base() { }

        //Método SelectAll
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Icone> SelectAll()
        {
            Modelo.Icone icone;
            List<Modelo.Icone> icones = new List<Modelo.Icone>();

            try
            {
                using (connection)
                {
                    connection.Open();
                    string sqlIcones = "SELECT * FROM Icone";
                    SqlCommand cmdIcones = new SqlCommand(sqlIcones, connection);
                    SqlDataReader drIcones;

                    using (drIcones = cmdIcones.ExecuteReader())
                    {
                        if (drIcones.HasRows)
                        {
                            while (drIcones.Read())
                            {
                                int idIcone = (int)drIcones["id"];
                                string iconeUrl = (string)drIcones["IconeUrl"];
                                icone = new Modelo.Icone(idIcone, iconeUrl);
                                icones.Add(icone);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }

            return icones;
        }

        //Método Select
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Icone Select(int icone_id)
        {
            //instancia um novo usuario
            Modelo.Icone icone = null;
            try
            {
                using (connection)
                {
                    //abre a conexão
                    connection.Open();
                    string sqlIcone = "SELECT * FROM Icone WHERE id = @id";
                    SqlCommand cmdIcone = new SqlCommand(sqlIcone, connection);
                    cmdIcone.Parameters.AddWithValue("@id", icone_id);
                    SqlDataReader drIcones;
                    using (drIcones = cmdIcone.ExecuteReader())
                    {
                        if (drIcones.HasRows)
                        {
                            //lê os resultados
                            while (drIcones.Read())
                            {
                                int idIcone = (int)drIcones["id"];
                                string iconeUrl = (string)drIcones["IconeUrl"];
                                icone = new Modelo.Icone(idIcone, iconeUrl);
                            }
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            return icone;
        }

        //Método Insert
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Icone icone)
        {
            try
            {
                if (this.Select(icone.Id) == null)
                {
                    using (connection)
                    {
                        connection.Open();
                        string sqlUsuario = "INSERT INTO Icone(IconeUrl) VALUES (@iconeUrl)";
                        SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, connection);
                        cmdUsuario.Parameters.AddWithValue("@iconeUrl", icone.IconeUrl);
                        cmdUsuario.ExecuteNonQuery();
                    }
                }
                else
                {
                    this.Update(icone);
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }

        //Método Update
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Icone icone)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    if (Select(icone.Id) != icone)
                    {
                        string sqlUsuario = "UPDATE Icone SET IconeUrl = @iconeUrl WHERE id = @id";
                        SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, connection);
                        cmdUsuario.Parameters.AddWithValue("@iconeUrl", icone.IconeUrl);
                        cmdUsuario.Parameters.AddWithValue("@id", icone.Id);
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
        public void Delete(Modelo.Icone icone)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    string sqlIcone = "DELETE FROM Icone WHERE id = @id";
                    SqlCommand cmdIcone = new SqlCommand(sqlIcone, connection);
                    cmdIcone.Parameters.AddWithValue("@id", icone.Id);
                    cmdIcone.ExecuteNonQuery();
                }
            }
            catch (SystemException)
            {
                throw;
            }
        }
    }
}