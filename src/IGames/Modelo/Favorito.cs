using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Favorito
    {

        public string Usuario_id { get; set; }

        public int Jogo_id { get; set; }

        public Favorito(string Usuario_id, int Jogo_id)
        {
            this.Usuario_id = Usuario_id;
            this.Jogo_id = Jogo_id;
        }
    }
}