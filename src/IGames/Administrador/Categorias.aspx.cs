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
            if (!Page.IsPostBack)
            {
                getCategorias();
            }
        }

        protected void getCategorias()
        {
            DAL.DALCategories cat = new DAL.DALCategories();
            List<Modelo.Categoria> cats = cat.SelectAll();
            this.DeletarCategorias.DataSource = cats;
            this.DeletarCategorias.DataTextField = "Descricao";
            this.DeletarCategorias.DataValueField = "ID";
            this.DataBind();
            DeletarCategorias.Items.Insert(0, "Escolha a categoria");

        }
        protected void DelCategoria_Click(object sender, EventArgs e)
        {
            string descricao = "";
            if (DeletarCategorias.SelectedItem.Value != "Escolha uma categoria")
            {
                DAL.DALCategories dalcate = new DAL.DALCategories();
                Modelo.Categoria cat = new Modelo.Categoria(descricao);
                dalcate.Delete(cat);
            }
        }
       protected void AddCategoria_Click(object sender, EventArgs e)
       {//ok
           string descricao = Categoria.Text;
           DAL.DALCategories dalcat = new DAL.DALCategories();
           Modelo.Categoria cat = new Modelo.Categoria(descricao);
           dalcat.Insert(cat);
       }
    }
}