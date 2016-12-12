<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Theme="Default" Inherits="IGames.Public.Cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">
<a href="index.aspx" class="brand-logo center">IGames</a>
</div>
</nav>
<main style="background:white">
<form id="form1" runat="server">
<div id="modal" class="modal">
<div class="modal-content">
<h4>Confirmação</h4>
<p>Cadastro realizado com sucesso</p>
</div>
<div class="modal-footer" class="center-align">
<asp:LinkButton ID="LinkButton1" runat="server" CssClass="modal-close waves-effect waves-green btn-flat btn" OnClick="Cadastrar_Click">OK</asp:LinkButton>
</div>
</div>
<div class="row">
<div class="card large register" style="margin-top: 0px;height: initial;">
<div class="col l6 offset-l3 s12">
<div class="card-content center-align">
    <h3>Cadastre-se</h3>
    <div class="carousel">
        <% foreach(IGames.Modelo.Icone icon in icones) { %>
        <%-- if(Request.QueryString["icone"] != null) { --%>
        <%-- if(int.Parse(Request.QueryString["icone"].ToString()) == icon.id) { --%>
        <a class="carousel-item" href="?icone=<%= icon.id %>" onclick="<% setIcon(); %>"><img src="<%= icon.iconeUrl %>"></a>
        <%-- } --%>
        <%-- } else {--%>
        <%-- <a class="carousel-item" href="?icone=<%= icon.id %>" onclick="<% setIcon(icon.id, icon.iconeUrl); %>"><img src="../<%= icon.iconeUrl %>"></a> --%>
        <%-- } --%>
        <% } %>
    </div>
    <div class="input-field">
    <asp:TextBox ID="nome" runat="server"></asp:TextBox>
    <label for="last_name">Nome</label>
    </div>
    <div class="input-field">
    <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
    <label for="last_name">Email</label>
    </div>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Inclua um endereço de email válido" ControlToValidate="email" ValidationExpression="[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"></asp:RegularExpressionValidator>
    <div class="input-field">
    <asp:TextBox ID="senha" runat="server" TextMode="Password"></asp:TextBox>
    <label for="last_name">Senha</label>
    </div>
    <div class="input-field">
    <asp:TextBox ID="confsenha" runat="server" TextMode="Password"></asp:TextBox>
    <label for="last_name">Confirmar senha</label>
    </div>
    <div class="col l7 offset-l7 m3 offset-m5 s7 offset-s1">
        <a class="waves-effect waves-light btn modal-trigger btn yellow darken-1" id="modal1" href="#modal" >Cadastrar</a>
    </div>
</div>
</div>
</div>
</div>
</form>
</main>
</asp:Content>