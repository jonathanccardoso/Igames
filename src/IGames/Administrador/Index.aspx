<%@ Page Title="Index" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Theme="Default" Inherits="IGames.Administrador.Index" %>
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
<li>
<a class="dropdown-button" data-activates="dropdown1">
<img src="<%= icon.iconeUrl %>" class="circle usericon"/>
</a>
<ul id="dropdown1" class="dropdown-content">
<li><a href="Perfil.aspx" class="white-text">Perfil</a></li>
<li><a href="?exit=1" onclick="<% Sair(); %>" class="white-text">Sair</a></li>
</ul>
</li>
</ul>
<ul class="side-nav" id="mobile-demo">
<li>
<div class="toolbar">
<a href="Perfil.aspx" class="perfil-mobile">
<img src="<%= icon.iconeUrl %>" class="circle usericon"/>
</a>
</div>
</li>
<li><a class="search"><i class="material-icons left">search</i>Pesquisar</a></li>
<li>
<form action="Busca.aspx" method="post"> 
<div class="input-field search-desktop">
<input id="search1" type="search" name="search">
<label for="search"><i class="material-icons">search</i></label><i class="material-icons close">close</i>
</div>
<button class="busca" type="submit" name="action"></button>
</form>
</li>
<li><a href="Categorias.aspx"><i class="material-icons left">clear_all</i>Categorias</a></li>
<li><a href="Forum.aspx"><i class="material-icons left">question_answer</i>Fórum</a></li>
<li><a href="Perfil.aspx"><i class="material-icons left">account_circle</i>Perfil</a></li>
<li><a href="?exit=1" onclick="<% Sair(); %>"><i class="material-icons left">exit_to_app</i>Sair</a></li>
</ul>
<a href="Index.aspx" class="brand-logo">IGames</a>
</div>
</nav>
<main>
<h3 class="center-align">Jogos Online</h3>
<div class="slider">
<ul class="slides">
<li>
<img src="../Images/img02.jpeg"> 
<div class="caption center-align">
<h3>Os jogos mais legais estão aqui!</h3>
<h5 class="light grey-text text-lighten-3">Crie sua conta!</h5>
</div>
</li>
<li>
<img src="../Images/img01.jpeg">
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
<% for(int i = 0; i <= jogonline.Count - 1; i++) { %>
<div class="col l3 s6">
<div class="card">
<a href="Jogo.aspx?jogo=<%= jogonline[i].nome %>"><img class="responsive-img" src="<%= jogonline[i].imagemUrl %>"> <br>
<b><%= jogonline[i].nome %></b></a>
<p><%= jogonline[i].descricao %></p>
</div>
</div>
<% } %>
</div>
<div id="destaque">
<% for (int i = 0; i <= destaque.Count - 1; i++) { %>
<div class="col l3 s6">
<div class="card">
<a href="Jogo.aspx?jogo=<%= destaque[i].nome %>"><img class="responsive-img" src="<%= destaque[i].imagemUrl %>"> <br>
<b><%= destaque[i].nome %></b></a>
<p><%= destaque[i].descricao %></p>
</div>
</div>B
<% } %>
</div>
<div id="recomendado">
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
</div>
</div>
<div class="row">
<a class="col l1 s12 btn modal-jogo" href="#modal-jogo">Adicionar Jogos</a>
<a class="col l1 offset-l4 btn" href="Icone.aspx">Icones</a>
<a class="col l1 offset-l4 s12 btn" href="Usuarios.aspx">Usuários</a>
</div>
<div id="modal-jogo" class="modal">
<form id="Form1" runat="server">
<div class="modal-content center-align">
<h4>Escolha o tipo:</h4>
<div class="row">
<div class="col l1 offset-14">
<%--<asp:RadioButton ID="online" runat="server" GroupName="escolha" />--%>
<asp:RadioButton ID="online" runat="server" GroupName="escolha"></asp:RadioButton>
<label for="ContentPlaceHolder1_online">Online</label>
</div>
<div class="col l1 offset-l1">
<asp:RadioButton ID="download" runat="server" GroupName="escolha" />
<label for="ContentPlaceHolder1_download">Download</label>
</div>
</div>
</div>
<div class="modal-footer center-align">
<asp:Button CssClass="modal-action modal-close waves-effect waves-green btn-flat" ID="Button1" runat="server" OnClick="Confirmar_Click" Text="Confirmar" />
<a href="#!" class="modal-action modal-close waves-effect waves-red btn-flat">Cancelar</a>
</div>
</form>
</div>
</main>
</asp:Content>
