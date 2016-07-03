using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoIntegrador
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnentrar_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["teste7ConnectionString"].ConnectionString;

            SqlConnection conexao = new SqlConnection(connStr);
            conexao.Open();
            SqlCommand insert = conexao.CreateCommand();


            insert.Parameters.AddWithValue("@email", email.Text);

            String fdp = insert.CommandText = "select email,senha from CadastroTeste where email = 'email.Text' and senha = 'senha.Text'";
            insert.ExecuteReader();

             if (fdp == email.Text)
             {
                Response.Redirect("~/index.aspx");
            }
            
            
        
        }
    }
}