﻿<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Theme="Default" Inherits="IGames.Public.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="nav-wrapper">
<a href="index.aspx" class="brand-logo center">Logo</a>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<div class="row">
<div class="card large register">
<div class="col l6 offset-l3 s12">
<div class="card-content center-align">
<h3>Cadastre-se</h3>
<form id="form1" runat="server">
<div class="input-field">
<asp:TextBox ID="nome" runat="server"></asp:TextBox>
<label for="last_name">Nome</label>
</div>
<div class="input-field">
<asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
<label for="last_name">Email</label>
</div>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Inclua um endereço de email válido" ControlToValidate="email" ValidationExpression="[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"></asp:RegularExpressionValidator>
<div class="input-field">
<asp:TextBox ID="senha" runat="server" TextMode="Password"></asp:TextBox>
<label for="last_name">Senha</label>
</div>
<div class="input-field">
<asp:TextBox ID="confsenha" runat="server" TextMode="Password"></asp:TextBox>
<label for="last_name">Confirmar senha</label>
</div>
<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="As senhas não correspondem" ControlToValidate="confsenha" ControlToCompare="senha"></asp:CompareValidator>
<div class="col l7 offset-l7 m3 offset-m5 s7 offset-s1">
<asp:LinkButton ID="Cadastrar" runat="server" CssClass="waves-effect waves-light btn yellow darken-1" OnClick="Cadastrar_Click">Cadastrar</asp:LinkButton>
</div>
</form>
</div>
</div>
</div>
</div>
</asp:Content>