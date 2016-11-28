using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.User
{
    public partial class Jogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*ESTRELAS DE AVALIAÇÃO*/
            if (Estrela1.ImageUrl == "/Images/EstrelaApagada.png")
            {
                Estrela1.Attributes.Add("onmouseover", "ContentPlaceHolder1_Estrela1.src = '/Images/EstrelaAcesa.png'");
                Estrela1.Attributes.Add("onmouseout", "ContentPlaceHolder1_Estrela1.src = '/Images/EstrelaApagada.png'");
            }
            else {
                Estrela1.Attributes.Add("onmouseover", "ContentPlaceHolder1_Estrela1.src = '/Images/EstrelaApagada.png'");
                Estrela1.Attributes.Add("onmouseout", "ContentPlaceHolder1_Estrela1.src = '/Images/EstrelaAcesa.png'");
            }
        }
        protected void Sair_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Session["email"] = null;
            Response.Redirect("~/Public/Index.aspx");
        }
        protected void Estrela1_Click(object sender, EventArgs e)
        {
            Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
            DAL.DALRates aval = new DAL.DALRates();
            Modelo.Avaliacao ava = new Modelo.Avaliacao(1, Session["id"].ToString());
            aval.Insert(ava);
        }
    }
}