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
        protected void Page_Load(object sender, EventArgs e)
        {
            Nome_user.Text = "";//TEM QUE OBTER NO LOGIN
            email_user.Text = Session["email"].ToString();
            senha_user.Text = Session["senha"].ToString();

            //deixar o textbox sem ser consultado
            //EX:NomeDaTextBox.Enabled = false;


            //if (Session["email"] != null)
            //{
            //    email_user.Text = Session["email"].ToString();
            //    Membership.GetUserNameByEmail(email_user.Text); //Usuario
            //    //Membership.GetUser(Membership.GetUserNameByEmail(email_user.Text)).GetPassword();
            //}
            ////else {
            ////    Response.Redirect("~/Public/Login.aspx");
            ////}
            //email_user.Text = Session["email"].ToString();
            //Membership.GetUserNameByEmail(email_user.Text); //Usuario
        }
        protected void EditarPerfil_Click(object sender, EventArgs e)
        {
            string nome = Nome_user.Text;
            string email = email_user.Text; 
            string senha = senha_user.Text;
            bool administrador = false;
            int Icone_id = 21;   //Tem que pegar o icone no login 

            DAL.DALUsers daluser = new DAL.DALUsers();
            Modelo.Usuario user = new Modelo.Usuario(nome, email, senha, administrador, Icone_id);
            daluser.Update(user);    
 
            
            
        }

    }
}