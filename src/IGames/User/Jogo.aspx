<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" Theme="Default" CodeBehind="Jogo.aspx.cs" Inherits="IGames.User.Jogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">  
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
<form id="Form1" runat="server">
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
<li><asp:LinkButton ID="login" runat="server"  OnClick="Sair_Click">Sair</asp:LinkButton>
</ul>
<ul class="side-nav" id="mobile-demo">
<li>
<div class="card grey lighten-1 search-mobile">
<div class="input-field inputy">
<input type="search" class="inp">
<label for="search"><i class="material-icons">search</i></label>
<i class="material-icons clos">close</i>
</div>
</div>
</li>
<li><a href="categorias.aspx"><i class="material-icons left">clear_all</i>Categorias</a></li>
<li><a href="forum.aspx"><i class="material-icons left">question_answer</i>Fórum</a></li>
<li><a href="login.aspx"><i class="material-icons left">fingerprint</i>Login</a></li>
</ul>
<a href="index.aspx" class="brand-logo">Logo</a>
</div>
</nav>
<main>
    <h3><asp:Label ID="NomeJogo" runat="server" Text="Nome do Jogo"></asp:Label></h3>
    <div class="row center-align">
    <div class="col l6 offset-l3 s5 offset-s3 m7 offset-m3">
    <div class="card white">
    <div class="left-align">
    <aside>

    <%--falta tabela no banco de dados--%>
    <%--<asp:LinkButton ID="cadastro" runat="server" OnClick="favoritar_Click"><i class="material-icons">favorite</i></asp:LinkButton><br />--%>

    <i class="material-icons">info</i><br />
    <i class="material-icons">help</i><br />
    </aside>
    </div>
    <div class="center-align">
        <asp:ImageButton ID="Estrela1" runat="server" ImageUrl="~/Images/EstrelaApagada.png" Width="10px" OnClick="Estrela1_Click" />

       <%-- <asp:ImageButton ID="Estrela2" runat="server" ImageUrl="~/Images/EstrelaApagada.png" Width="100px" OnClick="Estrela2_Click" />
        <asp:ImageButton ID="Estrela3" runat="server" ImageUrl="~/Images/EstrelaApagada.png" Width="100px" OnClick="Estrela3_Click" />
        <asp:ImageButton ID="Estrela4" runat="server" ImageUrl="~/Images/EstrelaApagada.png" Width="100px" OnClick="Estrela4_Click" />
        <asp:ImageButton ID="Estrela5" runat="server" ImageUrl="~/Images/EstrelaApagada.png" Width="100px" OnClick="Estrela5_Click" />--%>
    </div>
    <iframe id="frame" src="http://browserquest.mozilla.org/" width="620" height="400" scrolling="no" frameborder="0"></iframe> 
    </div>
    </div>
    </div>
    <h3 Class="center-align"><asp:Label ID="Label1" runat="server" Text="Relacionados"></asp:Label></h3>
    <h3 Class="center-align"><asp:Label ID="Label2"  runat="server" Text="Comentarios"></asp:Label></h3>
</form>
</main>
</asp:Content>