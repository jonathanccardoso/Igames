using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Comentario
    {
        public string descricao { get; set; }

        public int Jogo_id { get; set; }

        public int Usuario_id { get; set; }

        public Comentario(string descricao, int Jogo_id, int Usuario_id)
        {
            this.descricao = descricao;
            this.Jogo_id = Jogo_id;
            this.Usuario_id = Usuario_id;
        }
    }
}