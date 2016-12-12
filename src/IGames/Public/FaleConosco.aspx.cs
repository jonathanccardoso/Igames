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
        public Modelo.Usuario user { get; set; }

        public Modelo.Icone icon { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            initPage();
        }
        protected void initPage()
        {
            if (!Metodos.hasUser(Session["id"].ToString()))
            {
                this.user = Metodos.getUser(Session["id"].ToString());
                this.icon = Metodos.getIcon(this.user.Icone_id);
            }
            else
            {
                Response.Redirect("~/Public/Cadastro.aspx");
            }

        }
        protected void Send_Click(object sender, EventArgs e) {
            MailMessage message = new MailMessage(email.Text, "projetointegradorinfoweb@gmail.com", assunto.Text, mensagem.Text);
            SmtpClient emailClient = new SmtpClient();
            //Mandar mensagem para os administradores
        }
    }
}