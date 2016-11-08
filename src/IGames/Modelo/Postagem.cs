using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Postagem
    {
        public int Id { get; set; }

        public string Texto { get; set; }

        public string Data { get; set; }

        public string Hora { get; set; }

        public string UsuarioId { get; set; }

        public int? PostagemCitada { get; set; }

        public int ForumId { get; set; }

        public Postagem(int Id, string Texto, string Data, string Hora, string UsuarioId, int? PostagemCitada = null, int ForumId)
        {
            this.Id = Id;
            this.Texto = Texto;
            this.Data = Data;
            this.Hora = Hora;
            this.UsuarioId = UsuarioId;
            this.PostagemCitada = PostagemCitada;
            this.ForumId = ForumId;
        }
    }
}