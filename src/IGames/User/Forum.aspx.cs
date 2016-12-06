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
        public DAL.DALUsers daluser { get; set; }

        public Modelo.Usuario user { get; set; }

        public DAL.DALIcons dalicon { get; set; }

        public Modelo.Icone icon { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            hasUser();
            getUser();
            getIcon();
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
        protected void hasUser()
        {
            if (!Page.IsPostBack)
            {
                if (Session["id"] == null)
                {
                    Response.Redirect("~/Public/Cadastro.aspx");
                }
            }
        }

        protected void getUser()
        {
            if (!Page.IsPostBack)
            {
                this.daluser = new DAL.DALUsers();
                this.user = daluser.Select(Session["id"].ToString());
            }
        }

        protected void getIcon()
        {
            if (!Page.IsPostBack)
            {
                this.dalicon = new DAL.DALIcons();
                this.icon = dalicon.Select(this.user.Icone_id);
            }
        }

        protected void Sair()
        {
            if (Request.QueryString["exit"] != null)
            {
                if (int.Parse(Request.QueryString["exit"].ToString()) == 1)
                {
                    Session["id"] = null;
                    Session["email"] = null;
                    Response.Redirect("~/Public/Index.aspx");
                }
            }
        }
    }
}