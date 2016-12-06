﻿<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" Theme="Default" CodeBehind="Perfil.aspx.cs" Inherits="IGames.User.Perfil" %>
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
<img src="../<%= icon.iconeUrl %>" class="circle usericon"/>
<label><%= user.nome %></label>
</a>
<ul id="dropdown1" class="dropdown-content">
<li><a href="Pefil.aspx">Perfil</a></li>
<li><a href="Favoritos.aspx">Favoritos</a></li>
<li><a href="?exit=1" onclick="<% Sair(); %>">Sair</a></li>
</ul>
</li>
</ul>
<ul class="side-nav" id="mobile-demo">
<li>
<div class="toolbar">
<a href="Perfil.aspx" class="perfil-mobile">
<img src="../<%= icon.iconeUrl %>" class="circle usericon"/>
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
<li><a href="?exit=1" onclick="<% Sair(); %>"><i class="material-icons left">exit_to_app</i>Sair</a></li>
</ul>
<a href="#" class="brand-logo">Logo</a>
</div>
</nav>
<main>
    <h3 class="center-align"><asp:Label ID="NomeJogo" runat="server" Text="Editar perfil"></asp:Label></h3>
    <div class="row">
        <div class="col l6 offset-l3 s12 m10 offset-m1">
          <div class="card white">
               <div class="card-content">
                    <form runat="server">   
                        Nome:<asp:TextBox ID="Nome_user" runat="server"></asp:TextBox><br />
                        E-mail:<asp:TextBox ID="email_user" runat="server"></asp:TextBox><br />
                        Senha:<asp:TextBox ID="senha_user" runat="server" TextMode="Password"></asp:TextBox><br /><br />
                        <asp:LinkButton ID="EditaPerfil" runat="server" CssClass="waves-effect waves-light btn green darken-1" OnClick="EditarPerfil_Click">Editar</asp:LinkButton><br /><br />
                        <asp:LinkButton ID="DelUser" runat="server" CssClass="waves-effect waves-light btn green darken-1" OnClick="Excluir_Click">Excluir Conta</asp:LinkButton>
                    </form>
                </div>
            </div> 
          </div>
        </div>
</main>
</asp:Content>