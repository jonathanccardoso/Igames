<%@ Page Title="Jogo" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" Theme="Default" CodeBehind="Jogo.aspx.cs" Inherits="IGames.User.Jogo" %>
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
</a>
<ul id="dropdown1" class="dropdown-content">
<li><a href="Perfil.aspx">Perfil</a></li>
<li><a href="Favoritos.aspx">Favoritos</a></li>
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
<li><a href="?exit=1" onclick="<% Sair(); %>"><i class="material-icons left">exit_to_app</i>Sair</a></li>
</ul>
<a href="Index.aspx" class="brand-logo">Logo</a>
</div>
</nav>
<main>
<form id="Form1" runat="server">
<h3><asp:Label ID="NomeJogo" runat="server" Text="<%=  %>">"></asp:Label></h3>
    <div class="row center-align">
            <div class="col l6 offset-l3 s5 offset-s3 m7 offset-m3 center-align">
              <div class=" card from">
                  <div class="left-align">
                        <aside>
                         <a class="waves-effect waves-teal btn-flat modal-trigger" href="#favorito"><i class="material-icons" name="favorito">favorite_border</i></a><br />
                         <a class="waves-effect waves-teal btn-flat modal-trigger" href="#infoJogo"><i class="material-icons" name="informacoes">info</i></a><br /><br /><br /><br /><br /><br />
                          <div id="help" class="modal">
                            <div class="modal-content">
                              <h4 class="center-align">Como jogar ?</h4>
                            </div>
                            <div class="modal-footer center-align">
                                <asp:Button CssClass=" modal-action modal-close waves-effect waves-green btn-flat" ID="Button2" runat="server" Text="Confirmar" />
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
                        <div id="favorito" class="modal">
                            <div class="modal-content">
                              <h4 class="center-align">Adicionar esse jogo aos favoritos ?</h4>
                            </div>
                            <div class="modal-footer center-align">
                                <asp:Button CssClass=" modal-action modal-close waves-effect waves-green btn-flat" ID="Button4" runat="server" onClick="AddFavorito_Click" Text="Confirmar" />
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
                  <iframe id="Iframe1" src="http://browserquest.mozilla.org/" width="620px" height="400px" scrolling="no" frameborder="0"></iframe> 
              </div>
            </div>
        </div>
     <h3 Class="center-align"><asp:Label ID="Label3" runat="server" Text="Relacionados"></asp:Label></h3>
      <div id="recomendado">
        <% for(int i = 0; i <= 3; i++) { %>
            <div class="col l3 s6">
            <div class="card">
            <a href="Jogo.aspx?jogo=<%= recomendado[i].nome %>"><img class="responsive-img" src="<%= recomendado[i].imagemUrl %>"> <br>
            <b><%= recomendado[i].nome %></b></a>
            <p><%= recomendado[i].descricao %></p>
            </div>
            </div>
        <% } %>
        </div>
</form>
</main>
</asp:Content>