using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Usuario
    {
        public string id { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public bool administrador { get; set; }

        public int Icone_id { get; set; }

        public Usuario(string id, string nome, string email, string senha, bool administrador, int Icone_id)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.administrador = administrador;
            this.Icone_id = Icone_id;
        }
        public Usuario(string nome, string email, string senha, bool administrador, int Icone_id)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.administrador = administrador;
            this.Icone_id = Icone_id;
        }
    }
}