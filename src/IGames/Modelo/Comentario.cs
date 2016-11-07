using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Comentario
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string UsuarioId { get; set; }

        public Comentario(int Id, string Descricao, string UsuarioId)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.UsuarioId = UsuarioId;
        }
    }
}