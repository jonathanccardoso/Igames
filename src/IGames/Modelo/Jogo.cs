using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Image imagem { get; set; }

        public string nome { get; set; }

        public Jogo(int id, string jogoUrl, string descricao, string imagemUrl, string nome)
        {
            this.id = id;
            this.jogoUrl = jogoUrl;
            this.descricao = descricao;
            this.imagemUrl = imagemUrl;
            this.nome = nome;
        }

        public Jogo(string jogoUrl, string descricao, string imagemUrl, string nome)
        {
            this.jogoUrl = jogoUrl;
            this.descricao = descricao;
            this.imagemUrl = imagemUrl;
            this.nome = nome;
        }

        public Jogo(string jogoUrl, string descricao, Image imagem, string nome, string nomeImagem)
        {
            this.id = id;
            this.jogoUrl = jogoUrl;
            this.descricao = descricao;
            this.imagem = imagem;
            this.nome = nome;
            InsertImage(imagem, nomeImagem);
        }

        private void InsertImage(Image image, string nome)
        {
            Bitmap imgBitmap = new Bitmap(image);
            string path = HttpContext.Current.Request.PhysicalApplicationPath + "Images\\";
            this.imagemUrl = path + nome;
            imgBitmap.Save(imagemUrl);
        }
    }
}