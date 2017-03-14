<%@ Page Title="Fórum" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Inherits="IGames.User.Forum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">
<% if(!Request.Browser.IsMobileDevice) { %>
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
<li>
<a class="dropdown-button" data-activates="dropdown1">
<img src="<%= icon.iconeUrl %>" class="circle usericon"/>
</a>
<ul id="Ul1" class="dropdown-content">
<li><a href="Perfil.aspx">Perfil</a></li>
<li><a href="Favoritos.aspx">Favoritos</a></li>
<li><a href="../Sair.aspx">Sair</a></li>
</ul>
</li>
</ul>
</li>
</ul>
<% } else { %>
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
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
<% } %>
<a href="Index.aspx" class="brand-logo">IGames</a>
</div>
</nav>
<main>
<form runat="server">
    <% foreach (IGames.Modelo.Forum foru in foruns) { %>
    <div class="card">
    <div class="card-content">
    <div class="row">
    <aside class="col l1 s1 pic left center-align">
    <% foreach (IGames.Modelo.Usuario usuario in users) {
       foreach (IGames.Modelo.Icone icone in icons) {
       if(usuario.id == foru.Usuario_id) {
       if(usuario.Icone_id == icone.id) { %>
    <img src="<%= icone.iconeUrl %>" class="circle"><br />
    <b><%= usuario.nome %></b>
    </aside>
    <div class="col l11 s6 offset-s3 left-align">
    <h6><%= (foru.data.Day < 10 ? "0" : "") + foru.data.Day + "/" + foru.data.Month + "/" + foru.data.Year %> &nbsp;&nbsp; <%= foru.hora.Hour + ":" + foru.hora.Minute + (foru.hora.Second != 0 ? ":" + foru.hora.Second : "") %></h6>
    <h6 class="message"><%= foru.descricao %></h6>
    <a class="waves-effect center-align btn-flat left" href="?forum=<%= foru.id %>"><i class="material-icons chat">chat_bubble</i>Comentar</a>
    </div>
    </div>
    </div>
    </div>
    <% }
       }
       }
       } %>
       <% foreach(IGames.Modelo.Postagem post in postagens) { %>

      <% }
         } %>
    <div class="card">
    <div class="card-content">
    <div class="input-field col s6">
    <%--<form id="form1" runat="server">--%>
    <i class="material-icons prefix">mode_edit</i>
    <asp:TextBox ID="TextArea" runat="server" TextMode="MultiLine" CssClass="materialize-textarea"></asp:TextBox>
    <label for="ContentPlaceHolder2_TextArea">Escreva um comentário</label>
    <div class="row">
    <div class="col l2 offset-l10 s7 offset-s6">
    <asp:LinkButton ID="Send" runat="server" CssClass="btn waves-effect waves-light" OnClick="Send_Click">Enviar <i class="material-icons right">send</i></asp:LinkButton>
    </div>
    </div>
    <%--</form>--%>
    </div>
    </div>
    </div>
</form>
</main>
</asp:Content>