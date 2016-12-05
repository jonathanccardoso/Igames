<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Download.aspx.cs" Inherits="IGames.Administrador.Download" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">  
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
<ul class="right hide-on-med-and-down">
<li><a class="show-search"><i class="material-icons">search</i></a></li>
<li> 
<div class="input-field search-desktop">
<input id="search" type="search">
<label for="search"><i class="material-icons">search</i></label><i class="material-icons close">close</i>
</div>
</li>
<li><a href="Categorias.aspx">Categorias</a></li>
<li><a href="Forum.aspx">Fórum</a></li>
<li>
<a class="dropdown-button" data-activates="dropdown1">
<img src="<%= icon.iconeUrl %>" class="circle usericon"/>
<label><%= user.nome %></label>
</a>
<ul id="dropdown1" class="dropdown-content">
<li><a href="Pefil.aspx">Perfil</a></li>
<li><a href="Favoritos.aspx">Favoritos</a></li>
<li><a href="#" onclick="<% Sair(); %>">Sair</a></li>
</ul>
</li>
</ul>
<ul class="side-nav" id="mobile-demo">
<li>
<div class="toolbar">
<a href="Perfil.aspx" class="perfil-mobile">
<img src="<%= icon.iconeUrl %>" class="circle usericon"/>
<label><%= user.nome %></label>
</a>
</div>
</li>
<li><a class="search"><i class="material-icons left">search</i>Pesquisar</a></li>
<li>
<div class="input-field search-mobile">
<input type="text" class="mobileSearch"/>
<label for="mobileSearch"><i class="material-icons">search</i></label>
<i class="material-icons mobile-close">close</i>
</div>
</li>
<li><a href="Categorias.aspx"><i class="material-icons left">clear_all</i>Categorias</a></li>
<li><a href="Forum.aspx"><i class="material-icons left">question_answer</i>Fórum</a></li>
<li><a href="Perfil.aspx"><i class="material-icons left">account_circle</i>Perfil</a></li>
<li><a href="Favoritos.aspx"><i class="material-icons left">favorite</i>Favoritos</a></li>
<li><a href="#" onclick="<% Sair(); %>"><i class="material-icons left">exit_to_app</i>Sair</a></li>
</ul>
<a href="#" class="brand-logo">Logo</a>
</div>
</nav>
<main>
<form id="Form1" runat="server">
<div class="row">
<div class="col l10 offset-l1">
<div class="card">
<h2 class="card-title center">Download</h2>
<div class="row">
<div class="col l10 offset-l1">
<div class="file-field input-field">
<div class="btn">
<span>Jogo</span>
<asp:FileUpload ID="UploadGame" runat="server" AllowMultiple="True" webkitdirectory mozdirectory directory/>
</div>
<div class="file-path-wrapper">
<input class="file-path validate" type="text">
</div>
</div>
<div class="input-field">
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<label for="ContentPlaceholder2_TextBox1">Descrição</label>
</div>
<div class="file-field input-field">
<div class="btn">
<span>Imagem</span>
<asp:FileUpload ID="UploadImage" runat="server" />
</div>
<div class="file-path-wrapper">
<input class="file-path validate" type="text">
</div>
</div>
<div class="input-field">
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<label for="ContentPlaceholder2_TextBox2">Nome</label>
</div>
<asp:Button ID="addGame" runat="server" Text="Adicionar" CssClass="btn right" OnClick="addGame_Click"/>
</div>
</div>
</div> 
</div>
</div>
</form>
</main>
</asp:Content>