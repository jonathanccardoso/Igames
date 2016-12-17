<%@ Page Title="Categorias" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Theme="Default" Inherits="IGames.Public.Categorias" %>
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
<li><a href="#">Categorias</a></li>
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
<li><a href="login.aspx"><i class="material-icons left">account_circle</i>Login</a></li>
</ul>
<a href="index.aspx" class="brand-logo">IGames</a>
</div>
</nav>
<main>
 <h1 class="center-align">Categorias</h1><br>
    <div class="center-align">
		  <ul class="collapsible popout" data-collapsible="accordion">
              <% foreach(IGames.Modelo.Categoria cate in cats) { %>
		<li> 
		  <div class="collapsible-header" style="background-color:#0F3057"><%= cate.descricao %></div>
          <% if (IGames.Metodos.getJogoPelaCategoria(cate.id) != null) %>
		  <div class="collapsible-body">
			<div class="row">
                <% for(int i = 0; i <= 3; i++) { %>
                <div class="col l3 s6">
					<div class="card">
						<a href="Jogo.aspx?jogo=<%= IGames.Metodos.getJogoPelaCategoria(cate.id).nome ?? "" %>">
                        <img src="<%= IGames.Metodos.getJogoPelaCategoria(cate.id).imagemUrl ?? "" %>"/><br>
						<b><%= IGames.Metodos.getJogoPelaCategoria(cate.id).nome ?? "" %></b></a>
						<p><%= IGames.Metodos.getJogoPelaCategoria(cate.id).descricao ?? "" %></p>
					</div>
				</div>
                <% } %> 
                <% for(int i = 0; i <= 3; i++) {
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
                   } %>
			</div>
		  </div>
		</li>
              <% } %>
        </ul>
    </div>
</main>
</asp:Content>