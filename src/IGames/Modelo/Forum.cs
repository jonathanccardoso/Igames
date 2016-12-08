using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Forum
    {
        public int id { get; set; }

        public string descricao { get; set; }

        public DateTime data { get; set; }

        public DateTime hora { get; set; }

        public string Usuario_id { get; set; }

        public Forum(int id, string descricao, string data, string hora, string Usuario_id)
        {
            this.id = id;
            this.descricao = descricao;
            this.data = DateTime.Parse(data);
            this.hora = DateTime.Parse(hora);
            this.Usuario_id = Usuario_id;
        }

        public Forum(string descricao, string data, string hora, string Usuario_id)
        {
            this.descricao = descricao;
            this.data = DateTime.Parse(data);
            this.hora = DateTime.Parse(hora);
            this.Usuario_id = Usuario_id;
        }
    }
}