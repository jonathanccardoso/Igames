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
        #region categoria
        public static Modelo.Categoria getCategoria(int id) {
            return DAL.DALCategories.Select(id);
        }

        public static Modelo.Categoria getCategoriaPeloJogo(int jogo_id) {
            return DAL.DALCategories.Select(DAL.DALGamesCategories.Select(jogo_id).Categoria_id);
        }

        public static List<Modelo.Categoria> getCategorias()
        {
            return DAL.DALCategories.SelectAll();
        }

        #endregion
        #region jogo
        public static Modelo.Jogo getJogo(int id)
        {
            return DAL.DALGames.Select(id);
        }

        public static Modelo.Jogo getJogoPelaCategoria(int categoria_id) {
            return DAL.DALGames.Select(DAL.DALGamesCategories.SelectByCategory(categoria_id).Jogo_id);
        }

        public static List<Modelo.Jogo> getJogos()
        {
            return DAL.DALGames.SelectAll();
        }

        public static List<Modelo.Jogo> getJogosDestaque()
        {
            return DAL.DALGames.SelectTop();
        }

        public static List<Modelo.Jogo> getJogosRecomendados()
        {
            return DAL.DALGames.SelectRandom();
        }

        #endregion
        #region icone
        public static Modelo.Icone getIcone(int id)
        {
            return DAL.DALIcons.Select(id);
        }
        #endregion
        #region usuario
        public static bool hasUser(string id)
        {
            return id == null ? true : false;
        }

        public static Modelo.Usuario getUser(string id)
        {
            return DAL.DALUsers.Select(id);
        }
        #endregion

        public void Sair()
        {
            //Versão 01
            Session.Abandon();
            //Versão 02
            Session.Contents.RemoveAll();
        }
    }
}