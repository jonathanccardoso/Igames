using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Public
{
    public partial class Busca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getPesquisa();
        }

        protected void getPesquisa() {
            if (!Page.IsPostBack) {
                string a = Request.Form["search"];
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