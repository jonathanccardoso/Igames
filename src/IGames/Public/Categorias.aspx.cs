using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Public
{
    public partial class Categorias : System.Web.UI.Page
    {
        public List<Modelo.Categoria> cats { get; set; }

        public DAL.DALCategories dalcat { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getCategories();
            } 
        }
        protected void getCategories()
        {
            this.dalcat = new DAL.DALCategories();
            this.cats = this.dalcat.SelectAll();
        }
    }
}