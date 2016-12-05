<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Theme="Default" Inherits="IGames.Administrador.Usuarios" %>
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
<form runat="server" id="usuarios">
    <h1 class="center-align">Usuarios</h1><br>
    <div class="center-align">
		  <div class="collapsible-body">
			<div class="row">
                <% foreach(IGames.Modelo.Usuario usuario in users) {
				   foreach(IGames.Modelo.Icone icone in icones) {
                   if(usuario.Icone_id == icone.id) { %>
                <div class="col l3 s6">
					<div class="card">
                        <img src="<%= icone.iconeUrl %>" class="responsive-img"/>
						<b><%= usuario.nome %></b>						
					</div>
                    <!-- excluir usuario-->
                    <a class="btn-floating green modal-trigger" href="#modalDelete"><i class="material-icons">delete</i></a>
				</div>
                <% } 
                   } %>
                </div>
          </div>
              <% } %>
    </div>
    <div id="modalDelete" class="modal">
                <div class="modal-content">
                    <h4 class="center-align">Excluir usuario?</h4>
                         <div class="input-field">
                             <asp:TextBox ID="delUser" runat="server" Visible="true" Text="<%= usuario.nome %>">"></asp:TextBox><!--NÃO PODE APARECE-->
                         </div>
                 </div>
                 <div class="modal-footer center-align">
                         <asp:Button CssClass=" modal-action modal-close waves-effect waves-green btn-flat" ID="Button3" runat="server" OnClick="DelUser_Click" Text="Confirmar" />
                         <a href="#!" class=" modal-action modal-close waves-effect waves-green btn-flat">Cancelar</a><br /><br />
                 </div>
     </div>
</form>
</main>
</asp:Content>