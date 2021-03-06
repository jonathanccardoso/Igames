﻿<%@ Page Title="Categorias" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="IGames.User.Categorias" %>
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
<li><a href="Perfil.aspx">Perfil</a></li>
<li><a href="Favoritos.aspx">Favoritos</a></li>
<li><a href="../Sair.aspx">Sair</a></li>
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
<li><a href="Favoritos.aspx"><i class="material-icons left">favorite</i>Favoritos</a></li>
<li><a href="../Sair.aspx"><i class="material-icons left">exit_to_app</i>Sair</a></li>
</ul>
<a href="Index.aspx" class="brand-logo">IGames</a>
</div>
</nav>
<main>
 <h1 class="center-align">Categorias</h1><br>
    <<div class="center-align">
		  <ul class="collapsible popout" data-collapsible="accordion">
              <% foreach(IGames.Modelo.Categoria cate in cats) { %>
		<li> 
		  <div class="collapsible-header"><%= cate.descricao %></div>
		  <div class="collapsible-body">
			<div class="row">
                <%--<% for(int i = 0; i <= 3; i++) { %>
                <div class="col l3 s6">
					<div class="card">
						<a href="Jogo.aspx?jogo=<%= getJogo(IGames.DAL.DALGamesCategories.SelectByCategory(cate.id)).nome %>"><br>
						<b><%= getJogo(IGames.DAL.DALGamesCategories.SelectByCategory(cate.id)).nome %></b></a>
						<p><%= getJogo(IGames.DAL.DALGamesCategories.SelectByCategory(cate.id)).descricao %></p>
					</div>
		        </div>--%>

               <div id="recomendado" class="row">
                <% for(int i = 0; i <= 3; i++) { %>
                    <div class="col l3 s6">   
                    <div class="card center-align">
                    <%--<a href="Jogo.aspx?jogo=<%= recomendado[i].nome %>"><img class="responsive-img" width="100px" height="100px" src="../<%= recomendado[i].imagemUrl %>"> <br>--%>
                    <a href="Jogo.aspx?jogo=<%= getJogo(IGames.DAL.DALGamesCategories.SelectByCategory(cate.id).nome) %>">
                      <%--<img class="responsive-img" width="100px" height="100px" src="../<%= recomendado[i].imagemUrl %>"> <br>--%>
                   <%-- <b><%= recomendado[i].nome %></b></a>
                    <p><%= recomendado[i].descricao %></p>--%>
                    </div>
                    </div>  
                <% } %>
                </div>

                <% } %>              
			</div>
		  </div>
		</li>
        </ul>
    </div>
    <!--<main>
 <h1 class="center-align">Categorias</h1><br>
    <div class="center-align">
		  <ul class="collapsible popout" data-collapsible="accordion">
              <% foreach(IGames.Modelo.Categoria cate in cats) { %>
		<li> 
		  <div class="collapsible-header"><%= cate.descricao %></div>
		  <div class="collapsible-body">
			<div class="row">
                <% for(int i = 0; i <= 3; i++) { %>
                <div class="col l3 s6">
					<div class="card">
						<a href="Jogo.aspx?jogo=<%= getJogo(IGames.DAL.DALGamesCategories.SelectByCategory(cate.id).Jogo_id).nome %>"><br>
						<b><%= getJogo(IGames.DAL.DALGamesCategories.SelectByCategory(cate.id).Jogo_id).nome %></b></a>
						<p><%= getJogo(IGames.DAL.DALGamesCategories.SelectByCategory(cate.id).Jogo_id).descricao %></p>
					</div>
				</div>
                <% } %>

                <%--<% for(int i = 0; i <= 3; i++) {
                       if(jogos[i].id == jogoscategorias[i].Jogo_id && cate.id == jogoscategorias[i].Categoria_id) { %>
				<div class="col l3 s6">
					<div class="card">
						<a href="Jogo.aspx?jogo=<%= jogos[i].nome %>"><br>
						<b><%= jogos[i].nome %></b></a>
						<p><%= jogos[i].descricao %></p>
					</div>
				</div>
                <% jogos.Remove(jogos[i]);
                    } 
                   } %>--%>
			</div>
		  </div>
		</li>
              <% } %>
        </ul>
    </div>
</main>--->

</main>
</asp:Content>
