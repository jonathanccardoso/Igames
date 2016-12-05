<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Inherits="IGames.User.Forum" %>
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
    <div class="card">
    <div class="card-content">
    <div class="row coment">
    <aside class="col l1 s1 pic left center-align">
    <img src="http://lorempixel.com/100/100/" class="circle"><br />
    <b>Usuário</b>
    </aside>
    <div class="col l11 s6 offset-s3 left-align">
    <h6>12/04 &nbsp;&nbsp; 18:09</h6><br />
    <h6 class="message">Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur dapibus urna non dignissim. Ut pretium tempor pulvinar. Aliquam sit amet mauris laoreet, fringilla risus at, dignissim ante. Nulla turpis tellus, interdum sit amet congue lobortis, molestie et elit. In.</h6>
    <a class="waves-effect waves-teal center-align btn-flat left"><i class="material-icons like">favorite_border</i> Curtir</a>
    <a class="waves-effect center-align btn-flat left"><i class="material-icons chat">chat_bubble</i> Comentar</a>
    </div>
    </div>
    </div>
    </div>
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