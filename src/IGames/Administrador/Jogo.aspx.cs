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
    public partial class Jogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Confirmar_Click(object sender, EventArgs e)
        {
            string jogo = Request.QueryString["jogo"];//nome jogo

            string aSQLConecStr;
            aSQLConecStr = ConfigurationManager.ConnectionStrings["iGamesConnectionString"].ConnectionString;
            SqlConnection aSQLCon = new SqlConnection(aSQLConecStr);
            aSQLCon.Open();

            SqlCommand aSQL = new SqlCommand("DELETE FROM Jogo WHERE nome = '@NomeJogo'", aSQLCon);
            aSQL.Parameters.AddWithValue("@NomeJogo", jogo);
            aSQL.ExecuteNonQuery();

            Response.Redirect("Index.aspx");
        }
    }
}