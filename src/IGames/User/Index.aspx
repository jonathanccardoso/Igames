<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" Theme="Default" CodeBehind="Index.aspx.cs" Inherits="IGames.User.Index" %>
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
<li>
<a class="dropdown-button" data-activates="dropdown1">
<img src="<%= icon.iconeUrl %>" class="circle usericon"/>
<label><%= user.nome %></label>
</a>
<ul id="dropdown1" class="dropdown-content">
<li><a href="Pefil.aspx">Perfil</a></li>
<li><a href="Favoritos.aspx">Favoritos</a></li>
<li><a href="#" onclick="<% Sair(); %>">Sair</a></li>
</ul>
</li>
</ul>
<ul class="side-nav" id="mobile-demo">
<li>
<div class="toolbar">
<a href="Perfil.aspx" class="perfil-mobile">
<img src="<%= icon.iconeUrl %>" class="circle usericon"/>
<label><%= user.nome %></label>
</a>
</div>
</li>
<li><a class="search"><i class="material-icons left">search</i>Pesquisar</a></li>
<li>
<div class="input-field search-mobile">
<input type="text" class="mobileSearch"/>
<label for="mobileSearch"><i class="material-icons">search</i></label>
<i class="material-icons mobile-close">close</i>
</div>
</li>
<li><a href="Categorias.aspx"><i class="material-icons left">clear_all</i>Categorias</a></li>
<li><a href="Forum.aspx"><i class="material-icons left">question_answer</i>Fórum</a></li>
<li><a href="Perfil.aspx"><i class="material-icons left">account_circle</i>Perfil</a></li>
<li><a href="Favoritos.aspx"><i class="material-icons left">favorite</i>Favoritos</a></li>
<li><a href="#" onclick="<% Sair(); %>"><i class="material-icons left">exit_to_app</i>Sair</a></li>
</ul>
<a href="#" class="brand-logo">Logo</a>
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
</main>
</asp:Content>