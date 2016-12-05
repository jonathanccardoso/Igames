﻿using System;
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
        private bool avaliacao = false;

        public DAL.DALRates dalaval { get; set; }

        public DAL.DALGames daljogo { get; set; }

        public Modelo.Avaliacao avali { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            pegarAvaliacao();
        }
        protected void Sair_Click(object sender, EventArgs e)
        {
            Session["id"] = null;
            Session["email"] = null;
            Response.Redirect("~/Public/Index.aspx");
        }

        protected void pegarAvaliacao() {
            if (!Page.IsPostBack) {
                this.dalaval = new DAL.DALRates();
                this.daljogo = new DAL.DALGames();
                this.avali = this.dalaval.Select(this.daljogo.SelectByName("2048").id, Session["id"].ToString());
                if (avali.numeroEstrelas == 1) {
                    Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela2.ImageUrl = "~/Images/EstrelaApagada.png";
                    Estrela3.ImageUrl = "~/Images/EstrelaApagada.png";
                    Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                    Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                }
                else if (avali.numeroEstrelas == 2)
                {
                    Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela3.ImageUrl = "~/Images/EstrelaApagada.png";
                    Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                    Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                }
                else if (avali.numeroEstrelas == 3) {
                    Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                    Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                }
                else if (avali.numeroEstrelas == 4) {
                    Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela4.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                }
                else if (avali.numeroEstrelas == 5) {
                    Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela4.ImageUrl = "~/Images/EstrelaAcesa.png";
                    Estrela5.ImageUrl = "~/Images/EstrelaAcesa.png";
                }
                avaliacao = true;
            }
        }

        protected void Estrela1_Click(object sender, EventArgs e)
        {
            this.dalaval = new DAL.DALRates();
            this.daljogo = new DAL.DALGames();
            Modelo.Avaliacao ava = new Modelo.Avaliacao(1, daljogo.SelectByName("2048").id, Session["id"].ToString());
            if (this.dalaval.Select(this.daljogo.SelectByName("2048").id, Session["id"].ToString()) != null)
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela3.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                this.dalaval.Delete(ava);
                this.dalaval.Insert(ava);
                this.avaliacao = false;
            }
            else {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela3.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                this.dalaval.Insert(ava);
                this.avaliacao = true;
            }
        }
        protected void Estrela2_Click(object sender, EventArgs e)
        {
            DAL.DALRates dalaval = new DAL.DALRates();
            DAL.DALGames daljogo = new DAL.DALGames();
            Modelo.Avaliacao ava = new Modelo.Avaliacao(2, daljogo.SelectByName("2048").id, Session["id"].ToString());
            if (dalaval.Select(daljogo.SelectByName("2048").id, Session["id"].ToString()) != null)
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                dalaval.Delete(ava);
                dalaval.Insert(ava);
                this.avaliacao = false;
            }
            else
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                dalaval.Insert(ava);
                this.avaliacao = true;
            }
        }
        protected void Estrela3_Click(object sender, EventArgs e)
        {
            DAL.DALRates dalaval = new DAL.DALRates();
            DAL.DALGames daljogo = new DAL.DALGames();
            Modelo.Avaliacao ava = new Modelo.Avaliacao(3, daljogo.SelectByName("2048").id, Session["id"].ToString());
            if (dalaval.Select(daljogo.SelectByName("2048").id, Session["id"].ToString()) != null)
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                dalaval.Delete(ava);
                dalaval.Insert(ava);
                this.avaliacao = false;
            }
            else
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela4.ImageUrl = "~/Images/EstrelaApagada.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                dalaval.Insert(ava);
                this.avaliacao = true;
            }
        }
        protected void Estrela4_Click(object sender, EventArgs e)
        {
            DAL.DALRates dalaval = new DAL.DALRates();
            DAL.DALGames daljogo = new DAL.DALGames();
            Modelo.Avaliacao ava = new Modelo.Avaliacao(4, daljogo.SelectByName("2048").id, Session["id"].ToString());
            if (dalaval.Select(daljogo.SelectByName("2048").id, Session["id"].ToString()) != null)
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela4.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                dalaval.Delete(ava);
                dalaval.Insert(ava);
                this.avaliacao = false;
            }
            else
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela4.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela5.ImageUrl = "~/Images/EstrelaApagada.png";
                dalaval.Insert(ava);
                this.avaliacao = true;
            }
        }
        protected void Estrela5_Click(object sender, EventArgs e)
        {
            DAL.DALRates dalaval = new DAL.DALRates();
            DAL.DALGames daljogo = new DAL.DALGames();
            Modelo.Avaliacao ava = new Modelo.Avaliacao(5, daljogo.SelectByName("2048").id, Session["id"].ToString());
            if (dalaval.Select(daljogo.SelectByName("2048").id, Session["id"].ToString()) != null)
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela4.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela5.ImageUrl = "~/Images/EstrelaAcesa.png";
                dalaval.Delete(ava);
                dalaval.Insert(ava);
                this.avaliacao = false;
            }
            else
            {
                Estrela1.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela2.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela3.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela4.ImageUrl = "~/Images/EstrelaAcesa.png";
                Estrela5.ImageUrl = "~/Images/EstrelaAcesa.png";
                dalaval.Insert(ava);
                this.avaliacao = true;
            }
        }
    }
}