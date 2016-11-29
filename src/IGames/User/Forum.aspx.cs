using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.User
{
    public partial class Forum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Send_Click(object sender, EventArgs e)
        {
            /*string aSQLConecStr = ConfigurationManager.ConnectionStrings["iGamesConnectionString"].ConnectionString;
            SqlConnection aSQLCon = new SqlConnection(aSQLConecStr);
            aSQLCon.Open();
            SqlCommand aSQL = new SqlCommand("INSERT INTO Forum() VALUES()", aSQLCon);
            aSQL.Parameters.AddWithValue();
            aSQL.Parameters.AddWithValue();
            aSQL.Parameters.AddWithValue();
            aSQL.Parameters.AddWithValue();
            aSQL.ExecuteNonQuery();*/
        }
        protected void Sair_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Session["email"] = null;
            Response.Redirect("~/Public/Index.aspx");
        }
    }
}