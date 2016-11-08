using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Forum
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        public string Hora { get; set; }

        public string UsuarioId { get; set; }

        public int PostagemId { get; set; }

        public Forum(int Id, string Descricao, string Data, string Hora, string UsuarioId, int PostagemId)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Data = DateTime.Parse(Data);
            this.Hora = Hora;
            this.UsuarioId = UsuarioId;
            this.PostagemId = PostagemId;
        }
    }
}