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

        public string IconeUrl { get; set; }

        public int Adm { get; set; }

        public string Id { get; set; }

        public Usuario(string UserName, string Email, string IconeUrl, int Adm, string Id)
        {
            this.UserName = UserName;
            this.Email = Email;
            this.IconeUrl = IconeUrl;
            this.Adm = Adm;
            this.Id = Id;
        }
    }
}