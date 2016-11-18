<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Online.aspx.cs" Inherits="IGames.Administrador.Online" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<form id="Form1" runat="server">
<div class="row">
<div class="col l10 offset-l1">
<div class="card">
<h2 class="card-title center">Online</h2>
<div class="row">
<div class="col l10 offset-l1">
<div class="file-field input-field">
<div class="btn">
<span>Jogo</span>
<asp:FileUpload ID="UploadGame" runat="server" AllowMultiple="True" webkitdirectory mozdirectory directory/>
</div>
<div class="file-path-wrapper">
<input class="file-path validate" type="text">
</div>
</div>
<div class="input-field">
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<label for="ContentPlaceholder2_TextBox1">Descrição</label>
</div>
<div class="file-field input-field">
<div class="btn">
<span>Imagem</span>
<asp:FileUpload ID="UploadImage" runat="server" />
</div>
<div class="file-path-wrapper">
<input class="file-path validate" type="text">
</div>
</div>
<div class="input-field">
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<label for="ContentPlaceholder2_TextBox2">Nome</label>
</div>
<div class="input-field">
<asp:DropDownList ID="Categorias" Width="200" runat="server"></asp:DropDownList>
<label>Categoria</label>
</div>
<asp:Button ID="addGame" runat="server" Text="Adicionar" CssClass="btn right" OnClick="addGame_Click" />
</div>
</div>
</div> 
</div>
</div>
</form>
</asp:Content>
