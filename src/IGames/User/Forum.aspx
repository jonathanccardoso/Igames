<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Inherits="IGames.User.Forum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
<ul class="right hide-on-med-and-down">
<li><a class="show-search"><i class="material-icons">search</i></a></li>
<li>
<%--<form>--%>
<div class="input-field search-desktop">
<input id="search" type="search">
<label for="search"><i class="material-icons">search</i></label><i class="material-icons close">close</i>
</div>
<%--</form>--%>
</li>
<li><a href="categorias.aspx">Categorias</a></li>
<li><a href="#">Fórum</a></li>
</ul>
<ul class="side-nav" id="mobile-demo">
<li>
<div class="toolbar">
<a href="Perfil.aspx" class="perfil-mobile">
<asp:Image ID="Image2" runat="server" ImageUrl="~/Images/user.png" CssClass="circle usericon" />
<asp:Label ID="Label2" runat="server" Text="Usuário" Font-Bold="true"></asp:Label>
</a>
</div>
</li>
<li><a class="search"><i class="material-icons left">search</i>Pesquisar</a></li>
<li>
<div class="input-field search-mobile">
<%--<asp:TextBox ID="TextBox1" runat="server" CssClass="mobileSearch"></asp:TextBox>--%>
<label for="ContentPlaceholder2_mobileSearch"><i class="material-icons">search</i></label><i class="material-icons mobile-close">close</i>
</div>
</li>
<form id="Form1" runat="server">
<li><a href="categorias.aspx"><i class="material-icons left">clear_all</i>Categorias</a></li>
<li><a href="forum.aspx"><i class="material-icons left">question_answer</i>Fórum</a></li>
<li><asp:LinkButton ID="login" runat="server" OnClick="Sair_Click">Sair</asp:LinkButton>
</ul>
<a href="index.aspx" class="brand-logo">Logo</a>
</div>
</nav>
<main>
    <div class="card">
    <div class="card-content">
    <div class="row coment">
    <aside class="col l1 s1 pic left center-align">
    <img src="http://lorempixel.com/100/100/" class="circle"><br />
    <b>Usuário</b>
    </aside>
    <div class="col l11 s6 offset-s3 left-align">
    <h6>12/04 &nbsp;&nbsp; 18:09</h6><br />
    <h6 class="message">Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur dapibus urna non dignissim. Ut pretium tempor pulvinar. Aliquam sit amet mauris laoreet, fringilla risus at, dignissim ante. Nulla turpis tellus, interdum sit amet congue lobortis, molestie et elit. In.</h6>
    <a class="waves-effect waves-teal center-align btn-flat left"><i class="material-icons like">favorite_border</i> Curtir</a>
    <a class="waves-effect center-align btn-flat left"><i class="material-icons chat">chat_bubble</i> Comentar</a>
    </div>
    </div>
    </div>
    </div>
    <div class="card">
    <div class="card-content">
    <div class="input-field col s6">
    <%--<form id="form1" runat="server">--%>
    <i class="material-icons prefix">mode_edit</i>
    <asp:TextBox ID="TextArea" runat="server" TextMode="MultiLine" CssClass="materialize-textarea"></asp:TextBox>
    <label for="ContentPlaceHolder2_TextArea">Escreva um comentário</label>
    <div class="row">
    <div class="col l2 offset-l10 s7 offset-s6">
    <asp:LinkButton ID="Send" runat="server" CssClass="btn waves-effect waves-light" OnClick="Send_Click">Enviar <i class="material-icons right">send</i></asp:LinkButton>
    </div>
    </div>
    <%--</form>--%>
    </div>
    </div>
    </div>
</form>
</main>
</asp:Content>