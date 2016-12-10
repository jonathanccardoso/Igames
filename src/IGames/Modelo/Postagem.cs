using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Postagem
    {
        public int id { get; set; }

        public string texto { get; set; }

        public string data { get; set; }

        public string hora { get; set; }

        public string Usuario_id { get; set; }

        public int? Postagem_id { get; set; }

        public int Forum_id { get; set; }

        public Postagem(int id, string texto, string data, string hora, string Usuario_id, int? Postagem_id, int Forum_id)
        {
            this.id = id;
            this.texto = texto;
            this.data = data;
            this.hora = hora;
            this.Usuario_id = Usuario_id;
            this.Postagem_id = Postagem_id;
            this.Forum_id = Forum_id;
        }

        public Postagem(string texto, string data, string hora, string Usuario_id, int? Postagem_id, int Forum_id)
        {
            this.texto = texto;
            this.data = data;
            this.hora = hora;
            this.Usuario_id = Usuario_id;
            this.Postagem_id = Postagem_id;
            this.Forum_id = Forum_id;
        }

        public Postagem(string texto, string data, string hora, string Usuario_id, int Forum_id)
        {
            this.texto = texto;
            this.data = data;
            this.hora = hora;
            this.Usuario_id = Usuario_id;
            this.Forum_id = Forum_id;
        }

        public Postagem(string texto, string data, string hora, string Usuario_id, int Forum_id, int Postagem_id)
        {
            this.texto = texto;
            this.data = data;
            this.hora = hora;
            this.Usuario_id = Usuario_id;
            this.Postagem_id = Postagem_id;
            this.Forum_id = Forum_id;
        }
    }
}