using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
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
        

        //novo jeito
        string nomeAtual = "", emailAtual = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            initPage();
            if (!Page.IsPostBack)
            {
                //Nome_user.Text = user.nome;
                //email_user.Text = user.email;
            }
            nomeAtual = Session["nome"].ToString();
            emailAtual = Session["email"].ToString();
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

        protected void EditarPerfil_Click(object sender, EventArgs e) {
            //jeito novo
            string novoNome = "", novoEmail = "";

            if (Nome_user.Text == "") novoNome = nomeAtual;
            else novoNome = Nome_user.Text;

            if (email_user.Text == "") novoEmail = emailAtual;
            else novoEmail = email_user.Text;

            //editar
            //erro user está nulo resolve 
            this.user.nome = novoNome;
            this.user.email = novoEmail;
            string senha = this.user.senha;
            bool administrador = this.user.administrador;
            int Icone_id = this.user.Icone_id;
            Modelo.Usuario user = new Modelo.Usuario(novoNome, novoEmail, senha, administrador, Icone_id);
            DAL.DALUsers.Update(user);
        }

        //protected void Habilitar()
        //{
        //    if (Request.QueryString["edit"] != null)
        //    {
        //        if (int.Parse(Request.QueryString["edit"].ToString()) == 1)
        //        {
        //            if (Nome_user.Text != user.nome || email_user.Text != user.email)
        //            {//editar
        //                Editar_Click();
        //            }
        //            else
        //            {//não editar
        //                Response.Redirect("~/Perfil.aspx");
        //            }
        //        }
        //    }
        //}

        protected void Excluir(){
            if (Request.QueryString["delete"] != null)
            {
                if (int.Parse(Request.QueryString["delete"].ToString()) == 1)
                {
                    string id = Session["id"].ToString();
                    List<Modelo.Avaliacao> avaliacoes = DAL.DALRates.SelectAllByUser(id);//SelectByUser
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
                Response.Redirect("~/Public/Index.aspx");
            }
        }
    }
}
