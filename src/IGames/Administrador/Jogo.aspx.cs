﻿using System;
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
        {//REMOVER JOGO

            DAL.DALGames jogo = new DAL.DALGames();
            //Modelo.Jogo rem = new Modelo.Jogo("");
            //jogo.Delete(rem);
            
            Response.Redirect("Index.aspx");
        }
    }
}