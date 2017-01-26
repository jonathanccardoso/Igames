<%@ Page Title="Home" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Theme="Default" Inherits="IGames.Public.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">  
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
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
<a href="index.aspx" class="brand-logo">Igames</a>
</div>
</nav>
<main>
<h3 class="center-align">Jogos Online</h3>
<div class="slider">
<ul class="slides">
<li>
<img src="../Images/img01.jpeg"> 
<div class="caption center-align">
<h3>Os jogos mais legais estão aqui!</h3>
<h5 class="light grey-text text-lighten-3">Crie sua conta!</h5>
</div>
</li>
<li>
<img src="../Images/img02.jpeg">
<div class="caption left-align">
<h3></h3>
<h5 class="light grey-text text-lighten-3">Here's our small slogan.</h5>
</div>
</li>
<li>
<img src="../Images/equipe.png"> 
<div class="caption right-align">
<h3>Right Aligned Caption</h3>
<h5 class="light grey-text text-lighten-3">Here's our small slogan.</h5>
</div>
</li>
<li>
<img src="../Images/quemsomos.png">
<div class="caption center-align">
<h3>This is our big Tagline!</h3>
<h5 class="light grey-text text-lighten-3">Here's our small slogan.</h5>
</div>
</li>
<li>
<img src="../Images/browserQuest.jpg">
<div class="caption center-align">
<h3>Browser Quest</h3>
</div>
</li>
</ul>
</div>
<!---MENU--> 
<div class="row">
<div class="col s12 m12 l12">
<ul class="tabs flow-text">
<li class="tab col s3"><a href="#nalinha">Online</a></li>
<li class="tab col s3"><a href="#destaque">Destaque</a></li>
<li class="tab col s3"><a href="#recomendado">Recomendados</a></li>
</ul>
<!---MENU JOGOS-->
<div id="nalinha">
<% for(int i = 0; i <= online.Count - 1; i++) { %>
<div class="col l3 s6">
<div class="card">
<a href="Jogo.aspx?jogo=<%= online[i].nome %>"><img class="responsive-img" width="100px" height="100px" src="../<%= online[i].imagemUrl %>"> <br>
<b><%= online[i].nome %></b></a>
<p><%= online[i].descricao %></p>
</div>
</div>
<% } %>
</div>
<div id="destaque">
<% for (int i = 0; i <= destaque.Count - 1; i++) { %>
<div class="col l3 s6">
<div class="card">
<a href="Jogo.aspx?jogo=<%= destaque[i].nome %>"><img class="responsive-img" width="100px" height="100px" src="../<%= destaque[i].imagemUrl %>" > <br>
<b><%= destaque[i].nome %></b></a>
<p><%= destaque[i].descricao %></p>
</div>
</div>
<% } %>
</div>
<div id="recomendado">
<% for(int i = 0; i <=  recomendado.Count - 1; i++) { %>
<div class="col l3 s6">
<div class="card">
<a href="Jogo.aspx?jogo=<%= recomendado[i].nome %>"><img class="responsive-img" width="100px" height="100px" src="../<%= recomendado[i].imagemUrl %>" ><br>
<b><%= recomendado[i].nome %></b></a>
<p><%= recomendado[i].descricao %></p>
</div>
</div>
<% } %>
</div>
</div>
</div>
</main>
</asp:Content>