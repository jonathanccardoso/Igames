using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Jogo
    {
        public int? Id { get; set; }

        public string JogoUrl { get; set; }

        public string Descricao { get; set; }

        public string ImagemUrl { get; set; }

        public string Nome { get; set; }

        public int Tipo { get; set; }

        public int? AvaliacaoId { get; set; }

        public int? ComentarioId { get; set; }

        public Jogo(string JogoUrl, string Descricao, string ImagemUrl, string Nome, int Tipo, int? AvaliaçãoId = null, int? ComentarioId = null)
        {
            this.JogoUrl = JogoUrl;
            this.Descricao = Descricao;
            this.ImagemUrl = ImagemUrl;
            this.Nome = Nome;
            this.Tipo = Tipo;
            this.AvaliacaoId = AvaliaçãoId;
            this.ComentarioId = ComentarioId;
        }

        public Jogo(int? Id, string JogoUrl, string Descricao, string ImagemUrl, string Nome, int Tipo, int? AvaliaçãoId = null, int? ComentarioId = null)
        {
            this.Id = Id;
            this.JogoUrl = JogoUrl;
            this.Descricao = Descricao;
            this.ImagemUrl = ImagemUrl;
            this.Nome = Nome;
            this.Tipo = Tipo;
            this.AvaliacaoId = AvaliaçãoId;
            this.ComentarioId = ComentarioId;
        }
    }
}