<%@ Page Title="Jogo" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Jogo.aspx.cs" Theme="Default" Inherits="IGames.Public.Jogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">  
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
<ul class="right hide-on-med-and-down">
<li><a class="show-search"><i class="material-icons">search</i></a></li>
<li> 
<form action="Busca.aspx" method="post"> 
<div class="input-field search-desktop">
<input id="search" type="search" name="search">
<label for="search"><i class="material-icons">search</i></label><i class="material-icons close">close</i>
</div>
<button class="busca" type="submit" name="action"></button>
</form>
</li>
<li><a href="Categorias.aspx">Categorias</a></li>
<li><a href="Forum.aspx">Fórum</a></li>
<li><a href="Login.aspx">Login</a></li>
</ul>
<ul class="side-nav" id="mobile-demo">
<li>
<div class="card grey lighten-1 search-mobile">
<form action="Busca.aspx" method="post"> 
<div class="input-field search-desktop">
<input id="search1" type="search" name="search">
<label for="search"><i class="material-icons">search</i></label><i class="material-icons close">close</i>
</div>
<button class="busca" type="submit" name="action"></button>
</form>
</div>
</li>
<li><a href="categorias.aspx"><i class="material-icons left">clear_all</i>Categorias</a></li>
<li><a href="forum.aspx"><i class="material-icons left">question_answer</i>Fórum</a></li>
<li><a href="login.aspx"><i class="material-icons left">fingerprint</i>Login</a></li>
</ul>
<a href="index.aspx" class="brand-logo">IGames</a>
</div>
</nav>
<main>
<h3><%= jogo.nome %></h3>
    <div class="row center-align">
            <div class="col l7 offset-l3 s5 offset-s3 m7 offset-m3 center-align">
              <div class=" card from">
                  <div class="left-align">
                       <aside>
                        <a class="waves-effect waves-teal btn-flat modal-trigger" href="#infoJogo"><i class="material-icons">info</i></a><br /><br /><br /><br /><br /><br />
                        <div id="infoJogo" class="modal">
                            <div class="modal-content">
                              <h4 class="center-align">Descrições</h4>
                            </div>
                            <div class="modal-footer center-align">
                                <a href="#!" class=" modal-action modal-close waves-effect waves-green btn-flat">Confirmar</a>
                                <a href="#!" class=" modal-action modal-close waves-effect waves-green btn-flat">Cancelar</a>
                            </div>
                         </div>
                        </aside>
                    </div>
                  <br /><br /><%--http://browserquest.mozilla.org/ tamanho:  width="550px" height="450px"  ---%>
                       <iframe id="frame" src="../<%= jogo.jogoUrl %>" width="420px" height="450px" scrolling="no" frameborder="0"></iframe><br />
              </div>
            </div>
        </div>
     <h3 Class="center-align"><asp:Label ID="Label1" runat="server" Text="Relacionados"></asp:Label></h3>
      <div id="recomendado" class="row">
        <% for(int i = 0; i <=  recomendado.Count - 1; i++) { %>
            <div class="col l3 s6">
            <div class="card">
            <a href="Jogo.aspx?jogo=<%= recomendado[i].nome %>"><img class="responsive-img" src="<%= recomendado[i].imagemUrl %>"><br>
            <b><%= recomendado[i].nome %></b></a>
            <p><%= recomendado[i].descricao %></p>
            </div>
            </div>
        <% } %>
       </div>
</main>
</asp:Content>