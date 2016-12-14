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


        public Jogo(string jogoUrl, string descricao, string imagemUrl, string nome)
        {
            this.jogoUrl = jogoUrl;
            this.descricao = descricao;
            this.imagemUrl = imagemUrl;
            this.nome = nome;
        }

        public Jogo(int id, string jogoUrl, string descricao, string imagemUrl, string nome)
        {
            this.id = id;
            this.jogoUrl = jogoUrl;
            this.descricao = descricao;
            this.imagemUrl = imagemUrl;
            this.nome = nome;
        }
        public Jogo(int id, string jogoUrl, string descricao, Image imagem, string nome)
        {
            this.id = id;
            this.jogoUrl = jogoUrl;
            this.descricao = descricao;
            this.imagem = imagem;
            this.nome = nome;
            InsertImage(imagem, nome);
        }
        private void InsertImage(Image image, string nome)
        {
            Bitmap imgBitmap = new Bitmap(image);
            string unixTimestamp = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString();
            nome = unixTimestamp + ".jpg";
            //UploadImage.PostedFile.SaveAs(Server.MapPath("~") + "Images/" + UploadImage.FileName);
            string path, pasta = "Images";
            path = HttpContext.Current.Request.PhysicalApplicationPath + "Images\\";
            try
            {
                imgBitmap.Save(path + pasta + nome);
                this.imagemUrl = pasta + nome;
            }
            catch (SystemException)
            {
                throw;
            }
        }
    }
}