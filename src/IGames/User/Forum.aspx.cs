using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.User
{
    public partial class Forum : System.Web.UI.Page
    {
        public DAL.DALForum dalforum { get; set; }

        public List<Modelo.Forum> foruns { get; set; }

        public Modelo.Forum forum { get; set; }

        public DAL.DALUsers daluser { get; set; }

        public List<Modelo.Usuario> users { get; set; }

        public Modelo.Usuario user { get; set; }

        public DAL.DALIcons dalicon { get; set; }

        public List<Modelo.Icone> icons { get; set; }

        public Modelo.Icone icon { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            hasUser();
            getUser();
            getUsers();
            getIcon();
            getIcons();
            getForuns();
        }

        protected void Send_Click(object sender, EventArgs e)
        {
            this.dalforum = new DAL.DALForum();
            this.forum = new Modelo.Forum(TextArea.Text, DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString(), DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute, user.id);
            dalforum.Insert(forum);
        }

        protected void getForuns() {
            this.dalforum = new DAL.DALForum();
            this.foruns = dalforum.SelectAll();
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
            this.daluser = new DAL.DALUsers();
            this.user = daluser.Select(Session["id"].ToString());
        }

        protected void getUsers()
        {
            this.daluser = new DAL.DALUsers();
            this.users = daluser.SelectAll();
        }

        protected void getIcon()
        {
            this.dalicon = new DAL.DALIcons();
            this.icon = dalicon.Select(this.user.Icone_id);
        }

        protected void getIcons()
        {
            if (!Page.IsPostBack)
            {
                this.dalicon = new DAL.DALIcons();
                this.icons = dalicon.SelectAll();
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