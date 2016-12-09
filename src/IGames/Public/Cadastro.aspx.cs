using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Public
{
    public partial class Cadastro : System.Web.UI.Page
    {
        public DAL.DALIcons dalicone { get; set; }

        public List<Modelo.Icone> icones { get; set; }

        public Modelo.Icone icone { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            getIcon();
        }

        protected void Cadastrar_Click(object sender, EventArgs e)
        {
            
            if (nome.Text != null && senha.Text != null && email.Text != null && confsenha.Text != null)
            {
                DAL.DALUsers daluser = new DAL.DALUsers();
                setIcon();
                Modelo.Usuario user = new Modelo.Usuario(nome.Text, email.Text, senha.Text, false, icone.id);
                Membership.CreateUser(user.nome, user.senha, user.email);
                user.id = Membership.GetUser(Membership.GetUserNameByEmail(user.email)).ProviderUserKey.ToString();
                Roles.AddUserToRole(user.nome, "Usuario");
                daluser.Insert(user);
                FormsAuthentication.SetAuthCookie(user.email, true);
                Session["id"] = user.id;
                Session["email"] = user.email;
                Response.Redirect("~/User/Index.aspx");
            }
            else
            {
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void getIcon()
        {
            if (!Page.IsPostBack)
            {
                this.dalicone = new DAL.DALIcons();
                this.icones = dalicone.SelectAll();
            }
        }

        protected void setIcon() {
            if (Request.QueryString["icone"] != null){
                this.dalicone = new DAL.DALIcons();
                this.icone = DAL.DALIcons.Select(int.Parse(Request.QueryString["icone"]));
            }
        }
    }
}