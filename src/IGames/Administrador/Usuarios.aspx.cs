using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Usuarios : System.Web.UI.Page
    {
        public List<Modelo.Usuario> users { get; set; } 
        public DAL.DALUsers daluser { get; set; }
        
        public List<Modelo.Icone> icones { get; set; }
        public DAL.DALIcons dalicone { get; set; } 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                getUsers();
                getIcons();
            }
        }
        //usuarios
        protected void getUsers()
        {
            this.daluser = new DAL.DALUsers();
            this.users = this.daluser.SelectAll();
        }
        protected void getIcons()
        {
            this.dalicone = new DAL.DALIcons();
            this.icones = this.dalicone.SelectAll();
        }
        protected void DelUser_Click(object sender, EventArgs e)
        {

            // int id = int.Parse(listCatDel.SelectedItem.Value);
            string nomeUser = delUser.Text;
            DAL.DALUsers daluser = new DAL.DALUsers();
            Modelo.Usuario user = daluser.Select(nomeUser);
            daluser.Delete(user);
            Response.Redirect("~/Administrador/Usuarios.aspx");
        }
    }
}