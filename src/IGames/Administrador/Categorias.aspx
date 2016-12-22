<%@ Page Title="Categorias" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Theme="Default" Inherits="IGames.Administrador.Categorias" %>
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
 <h1 class="center-align">Categorias</h1><br>
    <div class="center-align">
		  <ul class="collapsible popout" data-collapsible="accordion">
              <% foreach(IGames.Modelo.Categoria cate in cats) { %>
		<li> 
		  <div class="collapsible-header"><%= cate.descricao %></div>
		  <div class="collapsible-body">
			<div class="row">
                <%--<% for(int i = 0; i <= 3; i++) { %>
                <div class="col l3 s6">
					<div class="card">
						<a href="Jogo.aspx?jogo=<%= getJogo(IGames.DAL.DALGamesCategories.SelectByCategory(cate.id)).nome %>"><br>
						<b><%= getJogo(IGames.DAL.DALGamesCategories.SelectByCategory(cate.id)).nome %></b></a>
						<p><%= getJogo(IGames.DAL.DALGamesCategories.SelectByCategory(cate.id)).descricao %></p>
					</div>
		        </div>--%>
                <% } %>              
			</div>
		  </div>
		</li>
        </ul>
    </div>

    <form id="Form1" runat="server">
        <div class="fixed-action-btn vertical click-to-toggle">
            <a class="btn-floating btn-large red" style="background-color:#123660">
              <i class="material-icons">menu</i>
            </a>
            <ul>
              <li><a class="btn-floating red modal-trigger" href="#modalInsert"><i class="material-icons">add</i></a></li>
              <li><a class="btn-floating yellow darken-1 modal-trigger" href="#modalUpdate"><i class="material-icons">mode_edit</i></a></li>
              <li><a class="btn-floating green modal-trigger" href="#modalDelete"><i class="material-icons">delete</i></a></li>
            </ul>
        </div>

      <div id="modalInsert" class="modal">
                <div class="modal-content">
                  <h4 class="center-align">Adicionar categoria?</h4>
                    <div class="input-field">
                        <asp:TextBox ID="InstCategoria" runat="server"></asp:TextBox>
                        <label for="ContentPlaceholder2_TextBox1">Descrição</label>
                        </div>
                </div>
                <div class="modal-footer center-align">
                        <asp:Button CssClass=" modal-action modal-close waves-effect waves-green btn-flat" ID="Button2" runat="server" OnClick="AddCategoria_Click" Text="Confirmar" />
                        <a href="#!" class=" modal-action modal-close waves-effect waves-green btn-flat">Cancelar</a><br /><br />
                </div>
      </div>
      <div id="modalUpdate" class="modal">
                    <div class="modal-content">
                      <h4 class="center-align">Editar categoria?</h4>
                        <div class="input-field">
                            <asp:DropDownList ID="listCateUpd" runat="server"></asp:DropDownList>
                            <label>Categoria</label>
                            <asp:TextBox ID="DescricaoUpdate" runat="server" Text="Descrição"></asp:TextBox>
                        </div>
                    </div>
                    <div class="modal-footer center-align">
                            <asp:Button CssClass=" modal-action modal-close waves-effect waves-green btn-flat" ID="Button1" runat="server" OnClick="EdtCategoria_Click" Text="Confirmar" />
                            <a href="#!" class=" modal-action modal-close waves-effect waves-green btn-flat">Cancelar</a><br /><br />
                    </div>
      </div>
        <div id="modalDelete" class="modal">
                <div class="modal-content">
                    <h4 class="center-align">Excluir categoria?</h4>
                         <div class="input-field">
                            <asp:DropDownList ID="listCatDel" runat="server" ></asp:DropDownList>
                            <label>Categoria</label>
                         </div>
                 </div>
                 <div class="modal-footer center-align">
                         <asp:Button CssClass=" modal-action modal-close waves-effect waves-green btn-flat" ID="Button3" runat="server" OnClick="DelCategoria_Click" Text="Confirmar" />
                         <a href="#!" class=" modal-action modal-close waves-effect waves-green btn-flat">Cancelar</a><br /><br />
                 </div>
          </div>
</form>
</main>
</asp:Content>
