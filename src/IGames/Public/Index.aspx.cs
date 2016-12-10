using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IGames.Public
{
    public partial class Index : System.Web.UI.Page
    {
        public List<Modelo.Jogo> online { get; set; }
        public List<Modelo.Jogo> destaque { get; set; }
        public List<Modelo.Jogo> recomendado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            getOnline();
            getDestaque();
            getRecomendado();
            if (Session["email"] != null)
            {
                DAL.DALUsers daluser = new DAL.DALUsers();
                Response.Redirect("~/" + (DAL.DALUsers.Select(Membership.GetUser(Membership.GetUserNameByEmail(Session["email"].ToString())).ProviderUserKey.ToString()).administrador ? "Administrador" : "User") + "/Index.aspx");
            }
        }

        protected void getOnline() {
            if (!Page.IsPostBack) {
                this.online = DAL.DALGames.SelectAll();
            }
        }

        protected void getDestaque() {
            if (!Page.IsPostBack)
            {
                this.destaque = DAL.DALGames.SelectTop();
            }
        }

        protected void getRecomendado() {
            if (!Page.IsPostBack)
            {
                this.destaque = DAL.DALGames.SelectRandom();
            }
        }
    }
}