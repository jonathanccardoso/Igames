using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace ProjetoIntegrador
{
    public partial class cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncadastro_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["teste7ConnectionString"].ConnectionString;

            SqlConnection conexao = new SqlConnection(connStr);
            conexao.Open();
            SqlCommand insert = conexao.CreateCommand();

            insert.CommandText = "INSERT INTO CadastroTeste(nome,email,senha) VALUES (@nome,@email,@senha)";
            insert.Parameters.AddWithValue("@nome", nome.Text);
            insert.Parameters.AddWithValue("@email", email.Text);
            insert.Parameters.AddWithValue("@senha", senha.Text);

            insert.ExecuteNonQuery();
            Response.Redirect("~/cadastrando.aspx");
        }
    }
}