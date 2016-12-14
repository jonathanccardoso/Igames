using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Administrador
{
    public partial class Forum : System.Web.UI.Page
    {
        public DAL.DALForum dalforum { get; set; }

        public List<Modelo.Forum> foruns { get; set; }

        public Modelo.Forum forum { get; set; }

        public DAL.DALPosts dalposts { get; set; }

        public List<Modelo.Postagem> postagens { get; set; }

        public Modelo.Postagem postagem { get; set; }

        public DAL.DALUsers daluser { get; set; }

        public List<Modelo.Usuario> users { get; set; }

        public Modelo.Usuario user { get; set; }

        public DAL.DALIcons dalicon { get; set; }

        public List<Modelo.Icone> icons { get; set; }

        public Modelo.Icone icon { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            getPosts();
            hasUser();
            getUser();
            getUsers();
            getIcon();
            getIcons();
            getForuns();
        }
        protected void Send_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["forum"] != null && Request.QueryString["postagem"] != null)
            {
                this.dalforum = new DAL.DALForum();
                this.forum = new Modelo.Forum(TextArea.Text, DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString(), DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute, user.id);
                DAL.DALForum.Insert(forum);
            }
            //fazer comentario
            else if (Request.QueryString["forum"] != null)
            {
                this.dalposts = new DAL.DALPosts();
                this.postagem = new Modelo.Postagem(TextArea.Text, DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString(), DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute, user.id, Convert.ToInt32(Request.QueryString["forum"].ToString()));
                DAL.DALPosts.Insert(postagem);
            }
            //responder comentario
            else if (Request.QueryString["postagem"] != null)
            {
                this.dalposts = new DAL.DALPosts();
                this.postagem = new Modelo.Postagem(TextArea.Text, DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString(), DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute, user.id, DAL.DALPosts.Select(Convert.ToInt32(Request.QueryString["postagem"].ToString())).Forum_id, Convert.ToInt32(Request.QueryString["postagem"].ToString()));
                DAL.DALPosts.Insert(postagem);
            }
        }

        protected void getForuns()
        {
            this.foruns = DAL.DALForum.SelectAll();
        }

        protected void getPosts()
        {
            this.postagens = DAL.DALPosts.SelectAll();
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
            this.user = DAL.DALUsers.Select(Session["id"].ToString());
        }

        protected void getUsers()
        {
            this.users = DAL.DALUsers.SelectAll();
        }

        protected void getIcon()
        {
            this.icon = DAL.DALIcons.Select(this.user.Icone_id);
        }

        protected void getIcons()
        {
            if (!Page.IsPostBack)
            {
                this.icons = DAL.DALIcons.SelectAll();
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