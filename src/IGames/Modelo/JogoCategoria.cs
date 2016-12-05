using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class JogoCategoria
    {

        public int Jogo_id { get; set; }

        public int Categoria_id { get; set; }

        public JogoCategoria(int Jogo_id, int Categoria_id)
        {
            this.Jogo_id = Jogo_id; 
            this.Categoria_id = Categoria_id;
        }

    }
}