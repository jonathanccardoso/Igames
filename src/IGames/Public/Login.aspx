<%@ Page Title="Login" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Theme="Default" Inherits="IGames.Public.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="nav-wrapper">
<a href="index.aspx" class="brand-logo center">Logo</a>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<div class="card medium">
<div class="row">
<div class="col l6 offset-l3 s12">
<div class="card-content center-align">
<h3>Login</h3>
</div>
<form id="Form1" name="loginform" method="post" runat="server">
<div class="input-field">
<asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
<label for="email">Email</label>
</div>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Digite seu email" ControlToValidate="email"></asp:RequiredFieldValidator>
<div class="input-field">
<asp:TextBox ID="senha" runat="server" TextMode="Password"></asp:TextBox>
<label for="senha">Senha</label>
</div>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Digite sua senha" ControlToValidate="senha"></asp:RequiredFieldValidator>
<div class="col l7 offset-l6 m3 offset-m5 s7 offset-s1">
<asp:LinkButton ID="cadastro" runat="server" CssClass="waves-effect waves-light btn yellow darken-1" OnClick="cadastro_Click">Cadastre-se</asp:LinkButton>
<asp:LinkButton ID="login" runat="server" CssClass="waves-effect waves-light btn green darken-1" OnClick="login_Click">Entrar</asp:LinkButton>
</div>
</form>
</div>
</div>
</div>
</asp:Content>