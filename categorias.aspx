﻿<%@ Page Title="Categorias" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" Theme="Default" CodeBehind="categorias.aspx.cs" Inherits="ProjetoIntegrador.categorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
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
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align="center">Categorias</h1><br>
	<div align="center">
		  <ul class="collapsible popout" data-collapsible="accordion">
		<li>
		  <div class="collapsible-header">Aventura</div>
		  <div class="collapsible-body">
			<div class="row">
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
			</div>
		  </div>
		</li>
		<li>
		  <div class="collapsible-header">Administração</div>
		  <div class="collapsible-body">
			  <div class="row">
					<div class="col l3 s6">
						<div class="card">
							<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
							<b>Título do Jogo</b></a>
							<p>Lorem ipsum dolor sit amet.</p>
						</div>
					</div>
					<div class="col l3 s6">
						<div class="card">
							<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
							<b>Título do Jogo</b></a>
							<p>Lorem ipsum dolor sit amet.</p>
						</div>
					</div>
					<div class="col l3 s6">
						<div class="card">
							<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
							<b>Título do Jogo</b></a>
							<p>Lorem ipsum dolor sit amet.</p>
						</div>
					</div>
					<div class="col l3 s6">
						<div class="card">
							<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
							<b>Título do Jogo</b></a>
							<p>Lorem ipsum dolor sit amet.</p>
						</div>
					</div>
				</div>
		  </div>
		</li>
		<li>
		  <div class="collapsible-header">Arcade</div>
		  <div class="collapsible-body">
			<div class="row">
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
			</div>
		  </div>
		</li>
		<li>
		  <div class="collapsible-header">Ação</div>
		  <div class="collapsible-body">
			<div class="row">
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
			</div>
		  </div>
		</li>
		<li>
		  <div class="collapsible-header">Clássicos</div>
		  <div class="collapsible-body">
			<div class="row">
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
			</div>
		  </div>
		</li>
		<li>
		  <div class="collapsible-header">Educacional</div>
		  <div class="collapsible-body">
			<div class="row">
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
			</div>
		  </div>
		</li>
		<li>
		  <div class="collapsible-header">Download</div>
		  <div class="collapsible-body">
			<div class="row">
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
				<div class="col l3 s6">
					<div class="card">
						<a href="#"><img class="responsive-img" src="http://lorempixel.com/120/120"> <br>
						<b>Título do Jogo</b></a>
						<p>Lorem ipsum dolor sit amet.</p>
					</div>
				</div>
			</div>
		  </div>
		</li>
	  </ul>
	</div>
</asp:Content>
