<%@ Page Title="Icone" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Icone.aspx.cs"  theme="Default" Inherits="IGames.Administrador.Icone" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<%--<div class="nav-wrapper">
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
<form id="Form2" runat="server">
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
<form id="Form3" runat="server">
<asp:LinkButton ID="LinkButton2" runat="server" OnClick="Sair"><i class="material-icons left">exit_to_app</i>Sair</asp:LinkButton>
</form>
</li>
</ul>
<% } %>
<a href="Index.aspx" class="brand-logo">IGames</a>
</div>--%>
</nav>
<main>
    <h3 class="center-align">Icones</h3><br>
    <div class="row">
    <% foreach(IGames.Modelo.Icone iconesDel in icones) { %>
    <div class="col l1 s6">
    <div class="card">
    <div class="card-close"> 
    <a class="btn btn-flat" href="?delete=<%= iconesDel.id %>" onclick="<% Delete(); %>">
    <i class="material-icons">close</i>
    </a> 
    </div>
    <div class="card-image">
    <img src="<%= iconesDel.iconeUrl %>" class="responsive-img"/>
    </div> 
    </div>
    </div>
    <% } %>
    </div>
    
   <form id="Form1" runat="server">
    <div class="fixed-action-btn vertical click-to-toggle">
            <a class="btn-floating btn-large red">
              <i class="material-icons">menu</i>
            </a>
            <ul>
              <li><a class="btn-floating red modal-trigger" href="#modalInsert"><i class="material-icons">add</i></a></li>
            </ul>
      </div>

       <div id="modalInsert" class="modal">
                <div class="modal-content">
                  <h4 class="center-align">Adicionar a URL do Icone ?</h4>
                    <div class="input-field">
                        <span>Imagem</span>
                        <asp:FileUpload ID="UploadImage" runat="server" />
                    </div>
                </div>
                <div class="modal-footer center-align">
                        <asp:Button CssClass=" modal-action modal-close waves-effect waves-green btn-flat" ID="Button2" runat="server" OnClick="AddIcone_Click" Text="Confirmar" />
                        <a href="#!" class=" modal-action modal-close waves-effect waves-green btn-flat">Cancelar</a><br /><br />
                </div>
        </div>

    </form>
</main>
</asp:Content>
