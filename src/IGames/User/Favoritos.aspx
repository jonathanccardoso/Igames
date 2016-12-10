<%@ Page Title="Favoritos" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Favoritos.aspx.cs" Theme="Default" Inherits="IGames.User.Favoritos" %>
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
</a>
<ul id="dropdown1" class="dropdown-content">
<li><a href="Perfil.aspx">Perfil</a></li>
<li><a href="Favoritos.aspx">Favoritos</a></li>
<li><a href="?exit=1" onclick="<% Sair(); %>">Sair</a></li>
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
<li><a href="?exit=1" onclick="<% Sair(); %>"><i class="material-icons left">exit_to_app</i>Sair</a></li>
</ul>
<a href="Index.aspx" class="brand-logo">Logo</a>
</div>
</nav>
<main>
   <h3 class="center-align"><asp:Label runat="server" Text="Favoritos"></asp:Label></h3>
    <div class="row">
        <div class="col l10 offset-l1 s12 m10 offset-m1">
          <div class="card white">
               <div class="card-content">
                    <% foreach (IGames.Modelo.Favorito favorito in favoritos){
                           if(favorito.Usuario_id == user.id) { %>
                    <div class="col l1 s6"> 
                    <div class="card">
                    <div class="card-image">
                    <a href="Jogo.aspx?jogo=IGames.DAL.DALGames.Select(favorito.Jogo_id).nome"></a>
                    <img src="<%= IGames.DAL.DALGames.Select(favorito.Jogo_id).imagemUrl %>" class="responsive-img"/>
                    </div>
                    </div>
                    </div>
                    <% }
                       } %>
                </div>
            </div> 
          </div>
        </div>
</main>
</asp:Content>
