using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Categoria
    {
        public int id { get; set; }

        public string descricao { get; set; }

        public Categoria(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }

        public Categoria(string descricao)
        {
            this.descricao = descricao;
        }
    }
}