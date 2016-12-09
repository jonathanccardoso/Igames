using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Public
{
    public partial class Busca : System.Web.UI.Page
    {
        public Modelo.Jogo jogo { get; set; }

        public DAL.DALGames daljogo { get; set; }
        
        public DAL.DALCategories dalcat { get; set; }

        public Modelo.Categoria categoria { get; set; }

        public List<Modelo.Jogo> jogos { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            getPesquisaJog();
            getPesquisaCat();
        }
        //BuscasJogos
        protected void getJogos()
        {
            this.daljogo = new DAL.DALGames();
            this.jogos = this.daljogo.SelectAll();
        }

        protected void getPesquisaJog() {
            if (!Page.IsPostBack) {
                string connectionString = ConfigurationManager.ConnectionStrings["iGamesConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string a = Request.Form["search"];
                string sqlBusca = "SELECT * FROM dbo.fn_Busca ("+ a +")";
                SqlCommand cmdBusca = new SqlCommand(sqlBusca, connection);
                SqlDataReader drBusca = cmdBusca.ExecuteReader();
                if (drBusca.HasRows) 
                {
                    while (drBusca.Read())
                    {
                        daljogo = new DAL.DALGames();
                        string nome = (string)drBusca["nome"];
                        jogo = daljogo.SelectByName(nome);
                    }
                }
                connection.Close();
            }
        }
        protected void getPesquisaCat()
        {
            if (!Page.IsPostBack)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["iGamesConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string a = Request.Form["search"];
                string sqlBusca = "SELECT * FROM dbo.fn_BuscaCat (" + a + ")";
                SqlCommand cmdBusca = new SqlCommand(sqlBusca, connection);
                SqlDataReader drBusca = cmdBusca.ExecuteReader();
                if (drBusca.HasRows)
                {
                    while (drBusca.Read())
                    {
                        dalcat = new DAL.DALCategories();
                        string descricao = (string)drBusca["descricao"];
                        categoria = dalcat.SelectAllByDescription(descricao);
                    }
                }
                connection.Close();
            }
        }

        protected void Busca_Click(object sender, EventArgs e){
            //TextBusca.Text = "";
            //view para resutados da busca
        }
        protected void Pesquisa() 
        {
            if (Request.QueryString["busca"] != null)
            {
                if (int.Parse(Request.QueryString["busca"].ToString()) == 1)
                {
                    //consulta no SQL para busca
                    Response.Redirect("~/Public/Index.aspx");
                }
            }
        }
    }
}