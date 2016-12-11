<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" Theme="Default" CodeBehind="Busca.aspx.cs" Inherits="IGames.User.Busca" %>
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
<a href="index.aspx" class="brand-logo">Logo</a>
</div>
</nav>
<main>
    <form id="Form1" runat="server" action="Busca.aspx" method="get"> 
          <%--<asp:TextBox ID="TextBusca" runat="server" Class="center-align"></asp:TextBox>          
          <a class="waves-effect waves-light btn green darken-1" href="?busca=1" onclick="<% Pesquisa(); %>">Busca</a>--%>
          <div class="card">
            <div class="row">
            <% foreach(IGames.Modelo.Jogo jogo in jogos) { 
                  foreach(IGames.Modelo.Categoria categoria in categorias) { %>
                <div class="col l4 s6">
                       <div class="jogos">
                        <img src="<%= jogo.imagemUrl %>" class="responsive-img"/>
						<div class="">
                            <b><%= jogo.descricao %></b><br />	
                            <b><%= categoria.descricao %></b><br />					
                        </div>
                       </div>
				</div>
                <% } 
                 } %>
               </div>
            </div>
    </form>
</main>
</asp:Content>
