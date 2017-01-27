<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Busca.aspx.cs" Theme="Default" Inherits="IGames.Public.Busca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">
<% if(!Request.Browser.IsMobileDevice) { %>
<ul class="right hide-on-med-and-down">
<li class="li-trigger"><a class="show-search"><i class="material-icons">search</i></a></li>
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
<% } else { %>
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
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
<% } %>
<a href="index.aspx" class="brand-logo">Igames</a>
</div>
</nav>
<main>
<h3>Resultados da pesquisa "<%= Request.QueryString["nome"] %>"</h3>
<div class="card">
<div class="row">
<% if(jogos != null) {
foreach(IGames.Modelo.Jogo jogo in jogos) {%>
<div class="col l4 s6">
<div class="jogos">
<a href="Jogo.aspx?jogo=<%= jogo.nome %>"><img class="responsive-img" width="100px" height="100px" src="../<%= jogo.imagemUrl %>"/>
<div>
<b><%= jogo.descricao %></b><br /></a>
<b><%= IGames.Metodos.getCategoriaPeloJogo(jogo.id).descricao ?? "" %></b><br />
</div>
</div>
</div>
<% }
   }%>
</div>
</div>
</main>
</asp:Content>
