<%@ Page Title="Login" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Theme="Default" Inherits="IGames.Public.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">
<a href="index.aspx" class="brand-logo center">Logo</a>
</div>
</nav>
<main>
<div class="card medium">
<div class="row">
<div class="col l6 offset-l3 s12">
<div class="card-content center-align">
<h3>Login</h3>
</div>
<div class="input-field">
<asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
<label for="email">Email</label>
</div>
<div class="input-field">
<asp:TextBox ID="senha" runat="server" TextMode="Password"></asp:TextBox>
<label for="senha">Senha</label>
</div>
<div class="col l7 offset-l6 m3 offset-m5 s7 offset-s2">
<asp:LinkButton ID="cadastro" runat="server" CssClass="waves-effect waves-light btn yellow darken-1" OnClick="cadastro_Click">Cadastre-se</asp:LinkButton>
<asp:LinkButton ID="login" runat="server" CssClass="waves-effect waves-light btn green darken-1" OnClick="login_Click">Entrar</asp:LinkButton>
</div>
</div>
</div>
</div>
</main>
</asp:Content>