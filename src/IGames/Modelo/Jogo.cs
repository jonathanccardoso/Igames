using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Jogo
    {
        public int id { get; set; }

        public string jogoUrl { get; set; }

        public string descricao { get; set; }

        public string imagemUrl { get; set; }

        public string nome { get; set; }

        public bool tipo { get; set; }

        public int? Categoria_id { get; set; }


        public Jogo(string jogoUrl, string descricao, string imagemUrl, string nome, bool tipo, int Categoria_id)
        {
            this.jogoUrl = jogoUrl;
            this.descricao = descricao;
            this.imagemUrl = imagemUrl;
            this.nome = nome;
            this.tipo = tipo;
            this.Categoria_id = Categoria_id;
        }

        public Jogo(int id, string jogoUrl, string descricao, string imagemUrl, string nome, bool tipo, int Categoria_id)
        {
            this.id = id;
            this.jogoUrl = jogoUrl;
            this.descricao = descricao;
            this.imagemUrl = imagemUrl;
            this.nome = nome;
            this.tipo = tipo;
            this.Categoria_id = Categoria_id;
        }
    }
}