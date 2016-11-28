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

        public string hora { get; set; }

        public int Usuario_id { get; set; }

        public Forum(string descricao, string data, string hora, int Usuario_id)
        {
            this.id = id;
            this.descricao = descricao;
            this.data = DateTime.Parse(data);
            this.hora = hora;
            this.Usuario_id = Usuario_id;
        }
    }
}