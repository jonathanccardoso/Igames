<%@ Page Title="Jogo" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Jogo.aspx.cs" Theme="Default" Inherits="IGames.Administrador.Jogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">
<% if(!Request.Browser.IsMobileDevice) { %>
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
<li><a href="Favoritos.aspx">Favoritos</a></li>
<li><a href="../Sair.aspx">Sair</a></li>
</ul>
</li>
</ul>
<% } else { %>
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
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
<li><a href="Favoritos.aspx"><i class="material-icons left">favorite</i>Favoritos</a></li>
<li><a href="../Sair.aspx"><i class="material-icons left">exit_to_app</i>Sair</a></li>
</ul>
<% } %>
<a href="Index.aspx" class="brand-logo">IGames</a>
</div>
</nav>
<main>
<form id="Form1" runat="server">
<h3 class="center-align"><%= jogo.nome %></h3>
    <div class="row center-align">
            <div class="col l6 offset-l3 s5 offset-s3 m7 offset-m3 center-align">
              <div class=" card from" style="height: inherit">
                  <div class="left-align">
                        <aside>
                        <a class="waves-effect waves-teal btn-flat modal-trigger" href="#infoJogo"><i class="material-icons">info</i></a><br /><br /><br /><br /><br /><br />
                        <a class="waves-effect waves-teal btn-flat modal-trigger" href="#delete"><i class="material-icons">delete</i></a>
                          <div id="delete" class="modal">
                            <div class="modal-content">
                              <h4 class="center-align">Excluir Jogo?</h4>
                            </div>
                            <div class="modal-footer center-align">
                                <%--<asp:Button CssClass=" modal-action modal-close waves-effect waves-green btn-flat" ID="Button1" runat="server" OnClick="Confirmar_Click" Text="Confirmar" />--%>
                                <a class="col l1 s10 btn modal-jogo" href="<% Response.Write(Request.RawUrl); %>&delete=<%= jogo.id %>" onclick="<% Delete(); %>">Confirmar</a>
                                <a href="#!" class=" modal-action modal-close waves-effect waves-green btn-flat">Cancelar</a>
                            </div>
                          </div>
                        <div id="infoJogo" class="modal">
                            <div class="modal-content">
                              <h4 class="center-align">Descrições</h4>
                            </div>
                            <div class="modal-footer center-align">
                                <asp:Button CssClass=" modal-action modal-close waves-effect waves-green btn-flat" ID="Button3" runat="server" Text="Confirmar" />
                                <a href="#!" class=" modal-action modal-close waves-effect waves-green btn-flat">Cancelar</a>
                            </div>
                         </div>
                        </aside>
                    </div>
                  <div class="center-align">
                        <asp:ImageButton ID="Estrela1" runat="server" ImageUrl="~/Images/EstrelaApagada.png" Width="30px" OnClick="Estrela1_Click" />
                        <asp:ImageButton ID="Estrela2" runat="server" ImageUrl="~/Images/EstrelaApagada.png" Width="30px" OnClick="Estrela2_Click" />
                        <asp:ImageButton ID="Estrela3" runat="server" ImageUrl="~/Images/EstrelaApagada.png" Width="30px" OnClick="Estrela3_Click" />
                        <asp:ImageButton ID="Estrela4" runat="server" ImageUrl="~/Images/EstrelaApagada.png" Width="30px" OnClick="Estrela4_Click" />
                        <asp:ImageButton ID="Estrela5" runat="server" ImageUrl="~/Images/EstrelaApagada.png" Width="30px" OnClick="Estrela5_Click" />
                   </div><br /><br />
                  <iframe id="frame"  src="<%= jogo.jogoUrl %>" width="420px" height="450px" scrolling="no" frameborder="0"></iframe><br />
              </div>
            </div>
        </div>
     <h3 Class="center-align"><asp:Label ID="Label1" runat="server" Text="Relacionados"></asp:Label></h3>
      <div id="recomendado" class="row"> 
        <% for(int i = 0; i <=  recomendado.Count - 1; i++) { %>
        <div class="col l3 s6">
        <div class="card">
        <a href="Jogo.aspx?jogo=<%= recomendado[i].nome %>"><img class="responsive-img"  width="100px" height="100px"  src="../<%= recomendado[i].imagemUrl %>"><br>
        <b><%= recomendado[i].nome %></b></a>
        <p><%= recomendado[i].descricao %></p>
        </div>
        </div>
        <% } %>
        </div>
</form>
</main>
</asp:Content>
