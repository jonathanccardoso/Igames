<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" Theme="Default" CodeBehind="Perfil.aspx.cs" Inherits="IGames.User.Perfil" %>
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
<form id="Form1" runat="server">
<ul id="dropdown1" class="dropdown-content">
<li><a href="Perfil.aspx">Perfil</a></li>
<li><a href="Favoritos.aspx">Favoritos</a></li>
<li>
<asp:LinkButton ID="LinkButton1" runat="server" OnClick="Sair">Sair</asp:LinkButton>
</li>
</ul>
</form>
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
<li>
<form id="Form2" runat="server">
<asp:LinkButton ID="LinkButton2" runat="server" OnClick="Sair"><i class="material-icons left">exit_to_app</i>Sair</asp:LinkButton>
</form>
</li>
</ul>
<% } %>
<a href="Index.aspx" class="brand-logo">IGames</a>
</div>
</nav>
<main>
    <h3 class="center-align"><asp:Label ID="NomeJogo" runat="server" Text="Editar perfil"></asp:Label></h3>
    <div class="row">
        <div class="col l6 offset-l3 s12 m10 offset-m1">
          <div class="card white">
               <div class="card-content">
                    <form runat="server">   
                        Nome:<asp:TextBox ID="Nome_user" runat="server" Text="<%= user.nome %>"></asp:TextBox><br />
                        E-mail:<asp:TextBox ID="email_user" runat="server" Text="<%= user.email %>"></asp:TextBox><br />
                        <asp:Button ID="EditarPerfil" runat="server" Text="Editar" CssClass="waves-effect waves-light btn green darken-1" OnClick="EditarPerfil_Click"></asp:Button><br />
                        <a class="waves-effect waves-light btn green darken-1" href="?delete=1" onclick="<% Excluir(); %>">Excluir Conta</a><br /><br />
                    </form>
                </div>
            </div> 
          </div>
        </div>
</main>
</asp:Content>