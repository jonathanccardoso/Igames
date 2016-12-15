using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//novo
using System.Net.Mail;

using System.Net.Configuration;
using System.Web.Mail;

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
        protected void Send_Click(object sender, EventArgs e)
        {
            /*MailMessage message = new MailMessage(emailUser.Text, "projetointegradorinfoweb@gmail.com", assunto.Text, mensagem.Text);
            SmtpClient emailClient = new SmtpClient();*/
            string remetente = "projetointegradorinfoweb@gmail.com";

            System.Net.Mail.MailMessage email = new System.Net.Mail.MailMessage();
            email.To.Add(emailUser.Text);
            email.From = new MailAddress(remetente, "IGames", System.Text.Encoding.UTF8);
            email.Subject = "Assunto:" + assunto.Text;
            email.SubjectEncoding = System.Text.Encoding.UTF8;
            email.Body = mensagem.Text;
            email.BodyEncoding = System.Text.Encoding.UTF8;
            email.IsBodyHtml = true;
            email.Priority = System.Net.Mail.MailPriority.High;

            SmtpClient client = new SmtpClient();  //Adicionando as credenciais do seu e-mail e senha:
            //nao necessita
            //client.Credentials = new System.Net.NetworkCredential(remetente, "digiteAquiSuaSenhaGmail");
            client.Port = 587; // Porta do Gmail para envio

            //erro no client.Host -> pois precisa de provedor
            client.Host = "smtp.gmail.com"; //Definindo o provedor que irá disparar o e-mail
            client.EnableSsl = true; //Gmail trabalha com Server Secured Layer
            try
            {
                client.Send(email);
                //controle resposta.Text = "Envio do E-mail com sucesso";
                //respostaEnvioLabel.Visible = true;
            }
            catch (Exception ex)
            {
                Response.Redirect("~/Index.aspx/");
            }
        }
    }
}