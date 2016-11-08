using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Icone
    {
        public int Id { get; set; }

        public string IconeUrl { get; set; }

        public Icone(int Id, string IconeUrl)
        {
            this.Id = Id;
            this.IconeUrl = IconeUrl;
        }
    }
}