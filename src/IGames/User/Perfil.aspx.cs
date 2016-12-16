using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.User
{
    public partial class Perfil : System.Web.UI.Page
    {
        public DAL.DALUsers daluser { get; set; }

        public Modelo.Usuario user { get; set; }

        public DAL.DALIcons dalicon { get; set; }

        public Modelo.Icone icon { get; set; }

        public DAL.DALRates dalrates { get; set; }

        public Modelo.Avaliacao avaliacao { get; set; }

        public int ctrl { get; set; }
         
        protected void Page_Load(object sender, EventArgs e)
        {
            initPage();
            if (!Page.IsPostBack)
            {
                Nome_user.Text = user.nome;
                email_user.Text = user.email;
            }
        }

        protected void initPage()
        {
            if (Session["id"] != null)
            {
                if (!Metodos.hasUser(Session["id"].ToString() ?? ""))
                {
                    this.user = Metodos.getUser(Session["id"].ToString());
                    this.icon = Metodos.getIcone(this.user.Icone_id);
                }
            }
            else
            {
                Response.Redirect("~/Public/Login.aspx");
            }
        }

        protected void Habilitar()
        {
            if (Request.QueryString["edit"] != null)
            {
                if (int.Parse(Request.QueryString["edit"].ToString()) == 1)
                {
                    if (Nome_user.Text != user.nome || email_user.Text != user.email)
                    {//editar
                        Editar_Click();
                    }
                    else
                    {//não editar
                        Response.Redirect("~/Perfil.aspx");
                    }
                }
            }
        }

        protected void Editar_Click()
        {
            string nome = Nome_user.Text;
            string email = email_user.Text;
            string senha = this.user.senha;
            bool administrador = this.user.administrador;
            int Icone_id = this.user.Icone_id;

            Modelo.Usuario user = new Modelo.Usuario(nome, email, senha, administrador, Icone_id);
            DAL.DALUsers.Update(user);
        } 

        protected void Excluir(){
            if (Request.QueryString["delete"] != null)
            {
                if (int.Parse(Request.QueryString["delete"].ToString()) == 1)
                {
                    string id = Session["id"].ToString();
                    DAL.DALRates dalavaliar = new DAL.DALRates();
                    List<Modelo.Avaliacao> avaliacoes = DAL.DALRates.SelectAllByUser(id);
                    foreach (Modelo.Avaliacao avaliar in avaliacoes)
                    {
                        DAL.DALRates.Delete(avaliar);
                    }
                    DAL.DALUsers daluser = new DAL.DALUsers();
                    Modelo.Usuario user = DAL.DALUsers.Select(id);
                    DAL.DALUsers.Delete(user);
                    Roles.RemoveUserFromRole(user.nome, (user.administrador) ? "Administrador" : "Usuario");
                    Membership.DeleteUser(user.nome);
                    Session["id"] = null;
                    Session["email"] = null;
                    Response.Redirect("~/Public/Index.aspx");
                }
            }
        }   
        /*protected void Editar() {
            if (Page.IsPostBack)
            {
                this.daluser.Update(this.user);
            }
        }*/

        protected void Sair()
        {
            if (Request.QueryString["exit"] != null)
            {
                Session.Contents.RemoveAll();
            }
        }
    }
}