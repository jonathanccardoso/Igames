<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="FaleConosco.aspx.cs" Theme="Default" Inherits="IGames.Public.FaleConosco" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
<ul class="right hide-on-med-and-down">
<li><a class="show-search"><i class="material-icons">search</i></a></li>
<li>
<form>
<div class="input-field search-desktop">
<input id="search" type="search">
<label for="search"><i class="material-icons">search</i></label><i class="material-icons close">close</i>
</div>
</form>
</li>
<li><a href="#">Categorias</a></li>
<li><a href="Forum.aspx">Fórum</a></li>
<li><a href="Login.aspx">Login</a></li>
</ul>
<ul class="side-nav" id="mobile-demo">
<li>
<div class="card grey lighten-1 search-mobile">
<form>
<div class="input-field inputy">
<input type="search" class="inp">
<label for="searc"><i class="material-icons">search</i></label>
<i class="material-icons clos">close</i>
</div>
</form>
</div>
</li>
<li><a href="categorias.aspx"><i class="material-icons left">clear_all</i>Categorias</a></li>
<li><a href="forum.aspx"><i class="material-icons left">question_answer</i>Fórum</a></li>
<li><a href="login.aspx"><i class="material-icons left">account_circle</i>Login</a></li>
</ul>
<a href="index.aspx" class="brand-logo">Logo</a>
</div>
</nav>
<main>
<form runat="server">
<div class="card">
<div class="card-content">
<div class="row coment">
<aside class="col l1 s1 pic left">
<img src="<%= icon.iconeUrl %>" class="circle">
</aside>
<div class="col l11 s6 offset-s3 left-align">
<b><%= user.nome %></b>
<div class="input-field">
<asp:TextBox ID="email" runat="server"></asp:TextBox>
<label for="ContentPlaceHolder1_email">Email</label>
</div>
<div class="input-field">
<asp:TextBox ID="assunto" runat="server"></asp:TextBox>
<label for="ContentPlaceHolder1_assunto">Assunto</label>
</div>
<div class="input-field">
<asp:TextBox ID="mensagem" runat="server" TextMode="MultiLine" CssClass="materialize-textarea"></asp:TextBox>
<label for="ContentPlaceHolder1_mensagem">Mensagem</label>
</div>
<asp:Button ID="Send" runat="server" Text="Enviar" OnClick="Send_Click"></asp:Button>
</div>
</div>
</div>
</div>
</form>
</main>
</asp:Content>