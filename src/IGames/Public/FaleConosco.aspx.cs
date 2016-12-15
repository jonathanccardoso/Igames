using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace IGames.Public
{
    public partial class FaleConosco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            initPage();
        }
        protected void initPage()
        {
            if (Session["id"] != null)
            {
                if (!Metodos.hasUser(Session["id"].ToString()))
                {
                    Response.Redirect("~/" + (Metodos.getUser(Session["id"].ToString()).administrador ? "Administrador" : "Usuario") + "/Index.aspx");
                }
            }
        }
        protected void Send_Click(object sender, EventArgs e) {
            MailMessage message = new MailMessage(email.Text, "projetointegradorinfoweb@gmail.com", assunto.Text, mensagem.Text);
            SmtpClient emailClient = new SmtpClient();
        }
    }
}