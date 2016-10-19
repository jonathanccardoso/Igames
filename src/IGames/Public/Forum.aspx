<%@ Page Title="Fórum" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Theme="Default" Inherits="IGames.Public.Forum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="nav-wrapper">
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
<ul class="right hide-on-med-and-down">
<li><a class="show-search"><i class="material-icons">search</i></a></li>
<li>
<form>
<div class="input-field search-desktop">
<input id="search" type="search">
<label for="search"><i class="material-icons">search</i></label><i class="material-icons close">close</i>
</div>
</form>
</li>
<li><a href="categorias.aspx">Categorias</a></li>
<li><a href="forum.aspx">Fórum</a></li>
<li><a href="login.aspx">Login</a></li>
</ul>
<ul class="side-nav" id="mobile-demo">
<li>
<div class="card grey lighten-1 search-mobile">
<form>
<div class="input-field inputy">
<input type="search" class="inp">
<label for="searc"><i class="material-icons">search</i></label>
<i class="material-icons clos">close</i>
</div>
</form>
</div>
</li>
<li><a href="categorias.aspx"><i class="material-icons left">clear_all</i>Categorias</a></li>
<li><a href="forum.aspx"><i class="material-icons left">question_answer</i>Fórum</a></li>
<li><a href="login.aspx"><i class="material-icons left">account_circle</i>Login</a></li>
</ul>
<a href="index.aspx" class="brand-logo">Logo</a>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<div class="card">
    <a href="../Properties/">../Properties/</a>
    <div class="card-content">
        <div class="row coment">
        <aside class="col l1 s1 pic left">
        <img src="http://lorempixel.com/100/100/" class="circle">
        </aside>
        <div class="col l11 s6 offset-s3 left-align">
        <b>Nome de usuário para teste</b>
        <h6 class="right">12/04</h6><br />
        <i>18:09</i><br />
        <h6 class="message">Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur dapibus urna non dignissim. Ut pretium tempor pulvinar. Aliquam sit amet mauris laoreet, fringilla risus at, dignissim ante. Nulla turpis tellus, interdum sit amet congue lobortis, molestie et elit. In.</h6>
        </div>
        </div>
    </div>
</div>
</asp:Content>