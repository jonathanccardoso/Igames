using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public Categoria(int Id, string Descricao)
        {
            this.Descricao = Descricao;
            this.Id = Id;
        }
    }
}