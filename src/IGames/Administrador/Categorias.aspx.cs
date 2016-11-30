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
        protected void AddCategoria_Click(object sender, EventArgs e)
        {
            string descricao = Categoria.Text;
            DAL.DALCategories cate = new DAL.DALCategories();
            Modelo.Categoria categoria = new Modelo.Categoria(descricao);
            cate.Insert(categoria);

           //Response.Redirect("~/Index.aspx");
        }
    }
}