using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace IGames
{
    public class Metodos
    {
        public HttpSessionState Session { get; set; }

        public static bool hasUser(string id)
        {
            return id == null ? true : false;
        }

        public static Modelo.Usuario getUser(string id)
        {
            return DAL.DALUsers.Select(id);
        }

        public static Modelo.Icone getIcon(int id)
        {
            return DAL.DALIcons.Select(id);
        }

        public void Sair()
        {
            //Versão 01
            Session.Abandon();
            //Versão 02
            Session.Contents.RemoveAll();
        }
    }
}