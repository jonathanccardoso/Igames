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

        public DAL.DALUsers dalusuario { get; set; }
         
        public Modelo.Usuario user { get; set; }

        public DAL.DALIcons dalicon { get; set; }

        public Modelo.Icone icon { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            hasUser();
            getUser();
            getIcon();

            if (!Page.IsPostBack) {
                getUsers();
                getIcons();
            }
        }
        //usuarios
        protected void getUsers()
        {
            this.dalusuario = new DAL.DALUsers();
            this.users = this.dalusuario.SelectAll();
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
        protected void hasUser()
        {
            if (!Page.IsPostBack)
            {
                if (Session["id"] == null)
                {
                    Response.Redirect("~/Public/Cadastro.aspx");
                }
            }
        }

        protected void getUser()
        {
            if (!Page.IsPostBack)
            {
                this.dalusuario = new DAL.DALUsers();
                this.user = dalusuario.Select(Session["id"].ToString());
            }
        }

        protected void getIcon()
        {
            if (!Page.IsPostBack)
            {
                this.dalicon = new DAL.DALIcons();
                this.icon = dalicon.Select(this.user.Icone_id);
            }
        }

        protected void Sair()
        {
            if (Request.QueryString["exit"] != null)
            {
                if (int.Parse(Request.QueryString["exit"].ToString()) == 1)
                {
                    Session["id"] = null;
                    Session["email"] = null;
                    Response.Redirect("~/Public/Index.aspx");
                }
            }
        }
    }
}