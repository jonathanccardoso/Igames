<%@ Page Title="Usuários" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Theme="Default" Inherits="IGames.Administrador.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">  
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
<ul class="right hide-on-med-and-down">
<li><a class="show-search"><i class="material-icons">search</i></a></li>
<li> 
<form action="Busca.aspx" method="post"> 
<div class="input-field search-desktop">
<input id="search" type="search" name="search">
<label for="search"><i class="material-icons">search</i></label><i class="material-icons close">close</i>
</div>
<button class="busca" type="submit" name="action"></button>
</form>
</li>
<li><a href="Categorias.aspx">Categorias</a></li>
<li><a href="Forum.aspx">Fórum</a></li>
<li>
<a class="dropdown-button" data-activates="dropdown1">
<img src="<%= icon.iconeUrl %>" class="circle usericon"/>
</a>
<ul id="dropdown1" class="dropdown-content">
<li><a href="Perfil.aspx">Perfil</a></li>
<li><a href="?exit=1" onclick="<% Sair(); %>">Sair</a></li>
</ul>
</li>
</ul>
<ul class="side-nav" id="mobile-demo">
<li>
<div class="toolbar">
<a href="Perfil.aspx" class="perfil-mobile">
<img src="<%= icon.iconeUrl %>" class="circle usericon"/>
</a>
</div>
</li>
<li><a class="search"><i class="material-icons left">search</i>Pesquisar</a></li>
<li>
<form action="Busca.aspx" method="post"> 
<div class="input-field search-desktop">
<input id="search1" type="search" name="search">
<label for="search"><i class="material-icons">search</i></label><i class="material-icons close">close</i>
</div>
<button class="busca" type="submit" name="action"></button>
</form>
</li>
<li><a href="Categorias.aspx"><i class="material-icons left">clear_all</i>Categorias</a></li>
<li><a href="Forum.aspx"><i class="material-icons left">question_answer</i>Fórum</a></li>
<li><a href="Perfil.aspx"><i class="material-icons left">account_circle</i>Perfil</a></li>
<li><a href="?exit=1" onclick="<% Sair(); %>"><i class="material-icons left">exit_to_app</i>Sair</a></li>
</ul>
<a href="Index.aspx" class="brand-logo">IGames</a>
</div>
</nav>
<main>
<form runat="server" id="usuarios">
    <h1 class="center-align">Usuarios</h1><br>
    <%--<h3 class="center-align">Icones</h3><br>
        <div class="row">
        <% foreach(IGames.Modelo.Icone icon in icones) { %>
        <div class="col l1 s6">
        <div class="card">
        <div class="card-close">
        <a class="btn btn-flat" href="?delete=<%= icon.id %>" onclick="<% Delete(); %>">
        <i class="material-icons">close</i>
        </a>
        </div>
        <div class="card-image">
        <img src="<%= icon.iconeUrl %>" class="responsive-img"/>
        </div>
        </div>
        </div>
        <% } %>
        </div>--%>
			<div class="row">
            <% foreach(IGames.Modelo.Usuario usuario in users) { %>
                <div class="col l4 s6">
				      <% foreach(IGames.Modelo.Icone icone in icones) {
                       if(usuario.Icone_id == icone.id) { %>
                        <div class="usuarios">
                        <img src="<%= icone.iconeUrl %>" class="responsive-img"/>
						<div class="">
                            <b><%= usuario.nome %></b><br />	
                            <b><%= usuario.email %></b><br />
                            <a class="col l1 s10 btn modal-jogo" href="#modalDelete">Deletar</a>
                            <%--<asp:HyperLink ID="Delete" runat="server">Deletar</asp:HyperLink>--%>					
                        </div>
                       </div>
				</div>
                <% } 
                  }
                } %>
               </div>
    
    <div id="modalDelete" class="modal">
                <div class="modal-content">
                    <h4 class="center-align">Excluir usuario?</h4>
                         <div class="input-field">
                             <!---usuario esta null-->
                             <asp:TextBox ID="delUser" runat="server" Visible="False" Text="<%= usuario.nome %>"></asp:TextBox><!--NÃO PODE APARECE-->
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