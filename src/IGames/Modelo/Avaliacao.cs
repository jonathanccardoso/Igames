using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Avaliacao
    {
        public int Id { get; set; }

        public int NumeroEstrelas { get; set; }

        public string UsuarioId { get; set; }

        public Avaliacao(int NumeroEstrelas, string UsuarioId)
        {
            this.NumeroEstrelas = NumeroEstrelas;
            this.UsuarioId = UsuarioId;
        }

        public Avaliacao(int Id, int NumeroEstrelas, string UsuarioId)
        {
            this.Id = Id;
            this.NumeroEstrelas = NumeroEstrelas;
            this.UsuarioId = UsuarioId;
        }
    }
}