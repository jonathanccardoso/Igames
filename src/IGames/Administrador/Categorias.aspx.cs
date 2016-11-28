using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Categorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GetCategories();
        }

        protected void GetCategories()
        {
            DAL.DALCategories cat = new DAL.DALCategories();
            cat.SelectAll();
        }
        protected void AdicionarCategoria_CLick()
        {
            //DAL.DALCategories cate = new DAL.DALCategories();
            //Modelo.Categoria categoria = new Modelo.Categoria(Id, Descricao);
            //cate.Insert = categoria;
        }
    }
}