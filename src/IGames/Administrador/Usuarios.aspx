﻿<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Theme="Default" Inherits="IGames.Administrador.Usuarios" %>
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
<%--<li><form id="Form1" runat="server"><asp:LinkButton ID="login" runat="server"  OnClick="Sair_Click">Sair</asp:LinkButton></form></li>--%>
</ul>
<ul class="side-nav" id="mobile-demo">
<li>
<div class="card grey lighten-1 search-mobile">
<div class="input-field inputy">
<input type="search" class="inp">
<label for="searc"><i class="material-icons">search</i></label>
<i class="material-icons clos">close</i>
</div>
</div>
</li>
<li><a href="categorias.aspx"><i class="material-icons left">clear_all</i>Categorias</a></li>
<li><a href="forum.aspx"><i class="material-icons left">question_answer</i>Fórum</a></li>
</ul>
<a href="index.aspx" class="brand-logo">Logo</a>
</div>
</nav>
<main>
    <form id="Form1" runat="server">
    </form>
</main>
</asp:Content>