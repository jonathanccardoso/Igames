<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Theme="Default" Inherits="IGames.Administrador.Categorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
<%--<form id="Form1" runat="server">--%>
    <ul class="right hide-on-med-and-down">
    <li><a class="show-search"><i class="material-icons">search</i></a></li>
    <li>
    <div class="input-field search-desktop">
    <input id="search" type="search">
    <label for="search"><i class="material-icons">search</i></label><i class="material-icons close">close</i>
    </div>
    </li>
    <li><a href="#">Categorias</a></li>
    <li><a href="Forum.aspx">Fórum</a></li>
    </ul>
    <ul class="side-nav" id="mobile-demo">
    <li>
    <div class="toolbar">
    <a href="Perfil.aspx" class="perfil-mobile">
   <%-- <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/user.png" CssClass="circle usericon" />
    <asp:Label ID="Label2" runat="server" Text="Usuário" Font-Bold="true"></asp:Label>--%>
    </a>
    </div>
    </li>
    <li><a class="search"><i class="material-icons left">search</i>Pesquisar</a></li>
    <li>
    <div class="input-field search-mobile">
<%--    <asp:TextBox ID="TextBox1" runat="server" CssClass="mobileSearch"></asp:TextBox>--%>
    <label for="ContentPlaceholder2_mobileSearch"><i class="material-icons">search</i></label><i class="material-icons mobile-close">close</i>
    </div>
    </li>
    <li><a href="categorias.aspx"><i class="material-icons left">clear_all</i>Categorias</a></li>
    <li><a href="forum.aspx"><i class="material-icons left">question_answer</i>Fórum</a></li>
    </ul>
<%--</form>--%>
<a href="index.aspx" class="brand-logo">Logo</a>
</div>
</nav>
<main>
<%--<form id="Form1" runat="server">--%>
    <h1 class="center-align">Categorias</h1><br>
	<div class="center-align">
		  <ul class="collapsible popout" data-collapsible="accordion">
		<li>
		  <div class="collapsible-header">Aventura<a class="waves-effect waves-teal btn-flat right" href="#"><i class="material-icons">delete</i></a></div>
		  <div class="collapsible-body">
			<div class="row">
				<div class="col l3 s6">
					<div class="card">
						<a href="Jogo.aspx">
                            <%--<form runat="server">--%>
                           <%-- <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/browserQuest.jpg" PostBackUrl="~/Administrador/Jogo.aspx?jogo=Browser Quest" />--%>
                              <%--  <img class="responsive-img" src="../Images/browserQuest.jpg"> --%><br>
						<b>Browser Quest</b></a>
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

    <form id="Form1" runat="server">
    <a class="waves-effect waves-teal btn modal-trigger" href="#modal"><i class="material-icons">add</i></a>
      <div id="modal" class="modal">
                <div class="modal-content">
                  <h4 class="center-align">Adicionar categoria?</h4>
                    <div class="input-field">
                        <asp:TextBox ID="Categoria" runat="server"></asp:TextBox>
                        <label for="ContentPlaceholder2_TextBox1">Descrição</label>
                        </div>
                </div>
                <div class="modal-footer center-align">
                <%--  <a href="#!" class=" modal-action modal-close waves-effect waves-green btn-flat" >Confirmar</a>--%>    
                        <asp:Button CssClass=" modal-action modal-close waves-effect waves-green btn-flat" ID="Button2" runat="server" OnClick="AddCategoria_Click" Text="Confirmar" />
                        <a href="#!" class=" modal-action modal-close waves-effect waves-green btn-flat">Cancelar</a><br /><br />
                     
                </div>
     </div>
</form>
</main>
</asp:Content>
