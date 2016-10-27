using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Usuario
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string iconeUrl { get; set; }

        public int Administrador { get; set; }

        public string id { get; set; }

        public Usuario(string userName, string email, string url_icone, int adm, string usuario_id)
        {
            userName = UserName;
            email = Email;
            url_icone = iconeUrl;
            adm = Administrador;
            usuario_id = id;
        }
    }
}