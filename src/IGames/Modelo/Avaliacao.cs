using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Avaliacao
    {
        public int Jogo_id { get; set; }

        public int numeroEstrelas { get; set; }

        public string Usuario_id { get; set; }

        public Avaliacao(int numeroEstrelas, int Jogo_id, string Usuario_id)
        {
            this.numeroEstrelas = numeroEstrelas;
            this.Jogo_id = Jogo_id;
            this.Usuario_id = Usuario_id;
        }
    }
}