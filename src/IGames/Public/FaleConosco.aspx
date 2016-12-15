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
<form runat="server">
<div class="card">
<div class="card-content">
<div class="input-field">
<asp:TextBox ID="email" runat="server" TextMode="Email" style="color:black"></asp:TextBox>
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
<asp:Button ID="Send" runat="server" class="waves-effect waves-light btn green darken-1" Text="Enviar" OnClick="Send_Click"></asp:Button>
</div>
</div>
</form>
</main>
</asp:Content>