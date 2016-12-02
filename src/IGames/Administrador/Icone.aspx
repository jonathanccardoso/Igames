<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Icone.aspx.cs"  theme="Default" Inherits="IGames.Administrador.Icone" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav>
<div class="nav-wrapper">  
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
<%--<form runat="server">--%>
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
<%--<li><asp:LinkButton ID="login" runat="server"  OnClick="Sair_Click">Sair</asp:LinkButton></li>--%>
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
<%--</form>--%>
<a href="index.aspx" class="brand-logo">Logo</a>
</div>
</nav>
<main>
    <div class="collapsible-body">
	    <div class="row">
		    <% foreach(IGames.Modelo.Icone icone in ico) { %>
              <div class="col l3 s6">
		   		<div class="card">
                  <img src="<%= icone.iconeUrl %>" class="responsive-img"/>
				</div>
			</div>
                <% } %>
        </div>
     </div>
    
   <form id="Form1" runat="server">
    <div class="fixed-action-btn vertical click-to-toggle">
            <a class="btn-floating btn-large red">
              <i class="material-icons">menu</i>
            </a>
            <ul>
              <li><a class="btn-floating red modal-trigger" href="#modalInsert"><i class="material-icons">add</i></a></li>
              <%--<li><a class="btn-floating yellow darken-1 modal-trigger" href="#modalUpdate"><i class="material-icons">mode_edit</i></a></li>--%>
              <li><a class="btn-floating green modal-trigger" href="#modalDelete"><i class="material-icons">delete</i></a></li>
            </ul>
      </div>

       <div id="modalInsert" class="modal">
                <div class="modal-content">
                  <h4 class="center-align">Adicionar a URL do Icone ?</h4>
                    <div class="input-field">
                        <span>Imagem</span>
                        <asp:FileUpload ID="UploadImage" runat="server" />
                        <%--<asp:TextBox ID="InstCategoria" runat="server"></asp:TextBox>
                        <label for="ContentPlaceholder2_TextBox1">Descrição</label>--%>
                    </div>
                </div>
                <div class="modal-footer center-align">
                        <asp:Button CssClass=" modal-action modal-close waves-effect waves-green btn-flat" ID="Button2" runat="server" OnClick="AddIcone_Click" Text="Confirmar" />
                        <a href="#!" class=" modal-action modal-close waves-effect waves-green btn-flat">Cancelar</a><br /><br />
                </div>
        </div>

    </form>
</main>
</asp:Content>
