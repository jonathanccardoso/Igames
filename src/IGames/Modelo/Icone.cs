using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IGames.Modelo
{
    public class Icone
    {
        public int id { get; set; }

        public string iconeUrl { get; set; }

        public Icone(int id, string iconeUrl)
        {
            this.id = id;
            this.iconeUrl = iconeUrl;
        }

        public Icone(string iconeUrl)
        {
            this.iconeUrl = iconeUrl;
        }
    }
}