<%@ Page Title="Login" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Theme="Default" Inherits="IGames.Public.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">
<a href="index.aspx" class="brand-logo center">IGames</a>
</div>
</nav>
<main>
<form runat="server">
<div class="card medium" style="background-color: #efefee;">
<div class="row">
<div class="col l6 offset-l3 s12">
<div class="card-content center-align">
<h3 style="color:black">Login</h3>
</div>
<div class="input-field">
<input type="email" name="email"/>
<label for="email">Email</label>
</div>
<div class="input-field">
<input type="password" name="senha"/>
<label for="senha">Senha</label>
</div>
<div class="col l4 s12 offset-s3">
<a class="waves-effect waves-light btn yellow darken-1" href="Cadastro.aspx">Cadastre-se</a>
</div>
<div class="col l1 offset-l6 s12 offset-s4">
<button class="waves-effect waves-light btn green darken-1" name="action" onclick="<% login(); %>">Entrar</button>
</div>
</div>
</div>
</div>
</form>
</main>
</asp:Content>