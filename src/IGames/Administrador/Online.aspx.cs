using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Online : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getCategories();
        }

        protected void addGame_Click(object sender, EventArgs e)
        {

        }

        protected void getCategories()
        {
            string aSQLConecStr;
            aSQLConecStr = ConfigurationManager.ConnectionStrings["iGamesConnectionString"].ConnectionString;
            SqlConnection aSQLCon = new SqlConnection(aSQLConecStr);

            try
            {
                using (aSQLCon)
                {
                    aSQLCon.Open();
                    SqlCommand aSQL = new SqlCommand("SELECT * FROM Categoria", aSQLCon);
                    SqlDataReader reader;

                    using (reader = aSQL.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Categorias.DataSource = reader;
                                Categorias.DataTextField = "descricao";
                                Categorias.DataValueField = "id";
                                Categorias.DataBind();
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (SystemException)
            {
                throw;
            }
            finally
            {
                aSQLCon.Close();
            }
        }
    }
}