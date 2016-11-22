<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Theme="Default" Inherits="IGames.Administrador.Index" %>
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
<h3 class="center-align">Jogos Online</h3>
<div class="slider">
<ul class="slides">
<li>
<img src="http://www.mudandoparamarte.com/wp-content/uploads/2015/04/kids-games-banner.jpg"> 
<div class="caption center-align">
<h3>Os jogos mais legais estão aqui!</h3>
<h5 class="light grey-text text-lighten-3">Crie sua conta!</h5>
</div>
</li>
<li>
<img src="https://gamedesignunesp.files.wordpress.com/2012/06/cropped-game-design-banner.jpg">
<div class="caption left-align">
<h3></h3>
<h5 class="light grey-text text-lighten-3">Here's our small slogan.</h5>
</div>
</li>
<li>
<img src="http://www.mylpl.info/wp-content/uploads/2015/08/Games-Banner-1140x400.png"> 
<div class="caption right-align">
<h3>Right Aligned Caption</h3>
<h5 class="light grey-text text-lighten-3">Here's our small slogan.</h5>
</div>
</li>
<li>
<img src="http://www.volt.com/uploadedImages/Blog/how_to_get_a_job_as_a_video_game_tester_banner.jpg">
<div class="caption center-align">
<h3>This is our big Tagline!</h3>
<h5 class="light grey-text text-lighten-3">Here's our small slogan.</h5>
</div>
</li>
<li>
<img src="../Images/browserQuest.jpg">
<div class="caption center-align">
<h3>Browser Quest</h3>
</div>
</li>
</ul>
</div>
<!---MENU--> 
<div class="row">
<div class="col s12 m12 l12">
<ul class="tabs flow-text">
<li class="tab col s3"><a href="#nalinha">Online</a></li>
<li class="tab col s3"><a href="#destaque">Destaque</a></li>
<li class="tab col s3"><a href="#recomendado">Recomendados</a></li>
</ul>
<!---MENU JOGOS-->
<div id="nalinha">
<div class="col l3 s6">
<div class="card">
<a href="Jogo.aspx"><img class="responsive-img" src="../Images/browserQuest.jpg"> <br>
<b>Browser Quest</b></a>
<p>Lorem ipsum dolor sit amet.</p>
</div>
</div>
<div class="col l3 s6">
<div class="card">
<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
<b>Título do Jogo</b></a>
<p>teste01</p>
</div>
</div>
<div class="col l3 s6">
<div class="card">
<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
<b>Título do Jogo</b></a>
<p>teste01</p>
</div>
</div>
<div class="col l3 s6">
<div class="card">
<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
<b>Título do Jogo</b></a>
<p>teste01</p>
</div>
</div>
</div>
<div id="destaque">
<div class="col l3 s6">
<div class="card">
<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
<b>Título do Jogo</b></a>
<p>Teste02</p>
</div>
</div>
<div class="col l3 s6">
<div class="card">
<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
<b>Título do Jogo</b></a>
<p>teste02</p>
</div>
</div>
<div class="col l3 s6">
<div class="card">
<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
<b>Título do Jogo</b></a>
<p>teste02</p>
</div>
</div>
<div class="col l3 s6">
<div class="card">
<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
<b>Título do Jogo</b></a>
<p>teste02</p>
</div>
</div>
</div>
<div id="recomendado">
<div class="col l3 s6">
<div class="card">
<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
<b>Título do Jogo</b></a>
<p>teste03</p>
</div>
</div>
<div class="col l3 s6">
<div class="card">
<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
<b>Título do Jogo</b></a>
<p>teste03</p>
</div>
</div>
<div class="col l3 s6">
<div class="card">
<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
<b>Título do Jogo</b></a>
<p>teste03</p>
</div>
</div>
<div class="col l3 s6">
<div class="card">
<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
<b>Título do Jogo</b></a>
<p>teste03</p>
</div>
</div>
</div>
</div>
</div>
<div class="row">
<a class="col s12 btn modal-jogo" href="#modal-jogo">Adicionar Jogos</a>
<a class="col l1 offset-l9 s12 btn" href="Usuarios.aspx">Usuários</a>
</div>
<div id="modal-jogo" class="modal">
<form id="Form1" runat="server">
<div class="modal-content center-align">
<h4>Escolha o tipo:</h4>
<div class="row">
<div class="col l1 offset-l4">
<asp:RadioButton ID="online" runat="server" GroupName="escolha" />
<label for="ContentPlaceHolder1_online">Online</label>
</div>
<div class="col l1 offset-l1">
<asp:RadioButton ID="download" runat="server" GroupName="escolha" />
<label for="ContentPlaceHolder1_download">Download</label>
</div>
</div>
</div>
<div class="modal-footer center-align">
<asp:Button CssClass="modal-action modal-close waves-effect waves-green btn-flat" ID="Button1" runat="server" OnClick="Confirmar_Click" Text="Confirmar" />
<a href="#!" class="modal-action modal-close waves-effect waves-red btn-flat">Cancelar</a>
</div>
</form>
</div>
</main>
</asp:Content>
