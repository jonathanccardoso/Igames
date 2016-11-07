using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Categoria
    {
        public string Id { get; set; }

        public string Descricao { get; set; }

        public Categoria(string Descricao, string Id)
        {
            this.Descricao = Descricao;
            this.Id = Id;
        }
    }
}