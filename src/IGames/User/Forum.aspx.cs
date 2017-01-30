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
        public List<Modelo.Forum> foruns { get { return DAL.DALForum.SelectAll(); } }

        public Modelo.Forum forum { get; set; }

        public List<Modelo.Postagem> postagens { get { return DAL.DALPosts.SelectAll(); } set; }

        public Modelo.Postagem postagem { get; set; }

        public List<Modelo.Usuario> users { get { return DAL.DALUsers.SelectAll(); } set; }

        public Modelo.Usuario user { get; set; }

        public List<Modelo.Icone> icons { get { return this.icons = DAL.DALIcons.SelectAll(); } set; }

        public Modelo.Icone icon { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            initPage();
        }

        protected void initPage()
        {
            if (Session["id"] != null)
            {
                if (Metodos.hasUser(Session["id"].ToString() ?? ""))
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

        protected void Send_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["forum"] != null && Request.QueryString["postagem"] != null)
            {
                this.forum = new Modelo.Forum(TextArea.Text, DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString(), DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute, user.id);
                DAL.DALForum.Insert(forum);
            }
            //fazer comentario
            else if (Request.QueryString["forum"] != null)
            {
                this.postagem = new Modelo.Postagem(TextArea.Text, DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString(), DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute, user.id, Convert.ToInt32(Request.QueryString["forum"].ToString()));
                DAL.DALPosts.Insert(postagem);
            }
            //responder comentario
            else if (Request.QueryString["postagem"] != null)
            {
                this.postagem = new Modelo.Postagem(TextArea.Text, DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString(), DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute, user.id, DAL.DALPosts.Select(Convert.ToInt32(Request.QueryString["postagem"].ToString())).Forum_id, Convert.ToInt32(Request.QueryString["postagem"].ToString()));
                DAL.DALPosts.Insert(postagem);
            }
        }

        protected void Sair(object sender, EventArgs e)
        {
            Session.Contents.RemoveAll();
            Response.Redirect("~/Public/Login.aspx");
        }
    }
}