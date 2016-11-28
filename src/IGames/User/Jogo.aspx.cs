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
            #region "Estrelas"
            if (Estrela1.ImageUrl == "/Images/EstrelaApagada.png")
            {
                Estrela1.Attributes.Add("onmouseover", "ContentPlaceHolder1_Estrela1.src = '/Images/EstrelaAcesa.png'");
                Estrela1.Attributes.Add("onmouseout", "ContentPlaceHolder1_Estrela1.src = '/Images/EstrelaApagada.png'");
            }
            else {
                Estrela1.Attributes.Add("onmouseover", "ContentPlaceHolder1_Estrela1.src = '/Images/EstrelaApagada.png'");
                Estrela1.Attributes.Add("onmouseout", "ContentPlaceHolder1_Estrela1.src = '/Images/EstrelaAcesa.png'");
            }

            if (Estrela2.ImageUrl == "/Images/EstrelaApagada.png")
            {
                Estrela2.Attributes.Add("onmouseover", "ContentPlaceHolder1_Estrela2.src = '/Images/EstrelaAcesa.png'");
                Estrela2.Attributes.Add("onmouseout", "ContentPlaceHolder1_Estrela2.src = '/Images/EstrelaApagada.png'");
            }
            else {
                Estrela2.Attributes.Add("onmouseover", "ContentPlaceHolder1_Estrela2.src = '/Images/EstrelaApagada.png'");
                Estrela2.Attributes.Add("onmouseout", "ContentPlaceHolder1_Estrela2.src = '/Images/EstrelaAcesa.png'");
            }

            if (Estrela3.ImageUrl == "/Images/EstrelaApagada.png")
            {
                Estrela3.Attributes.Add("onmouseover", "ContentPlaceHolder1_Estrela3.src = '/Images/EstrelaAcesa.png'");
                Estrela3.Attributes.Add("onmouseout", "ContentPlaceHolder1_Estrela3.src = '/Images/EstrelaApagada.png'");
            }
            else
            {
                Estrela3.Attributes.Add("onmouseover", "ContentPlaceHolder1_Estrela3.src = '/Images/EstrelaApagada.png'");
                Estrela3.Attributes.Add("onmouseout", "ContentPlaceHolder1_Estrela3.src = '/Images/EstrelaAcesa.png'");
            }

            if (Estrela4.ImageUrl == "/Images/EstrelaApagada.png")
            {
                Estrela4.Attributes.Add("onmouseover", "ContentPlaceHolder1_Estrela4.src = '/Images/EstrelaAcesa.png'");
                Estrela4.Attributes.Add("onmouseout", "ContentPlaceHolder1_Estrela4.src = '/Images/EstrelaApagada.png'");
            }
            else
            {
                Estrela4.Attributes.Add("onmouseover", "ContentPlaceHolder1_Estrela4.src = '/Images/EstrelaApagada.png'");
                Estrela4.Attributes.Add("onmouseout", "ContentPlaceHolder1_Estrela4.src = '/Images/EstrelaAcesa.png'");
            }
            if (Estrela5.ImageUrl == "/Images/EstrelaApagada.png")
            {
                Estrela5.Attributes.Add("onmouseover", "ContentPlaceHolder1_Estrela5.src = '/Images/EstrelaAcesa.png'");
                Estrela5.Attributes.Add("onmouseout", "ContentPlaceHolder1_Estrela5.src = '/Images/EstrelaApagada.png'");
            }
            else
            {
                Estrela5.Attributes.Add("onmouseover", "ContentPlaceHolder1_Estrela5.src = '/Images/EstrelaApagada.png'");
                Estrela5.Attributes.Add("onmouseout", "ContentPlaceHolder1_Estrela5.src = '/Images/EstrelaAcesa.png'");
            }
            #endregion
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
            DAL.DALRates dalaval = new DAL.DALRates();
            DAL.DALGames daljogo = new DAL.DALGames();
            //Create method 'SelectByName' in DALGames
            //Modelo.Avaliacao ava = new Modelo.Avaliacao(true, daljogo.SelectByName(Request.QueryString["jogo"]), Session["id"].ToString());
            //dalaval.Insert(ava);
        }
    }
}