<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Jogo.aspx.cs" Theme="Default" Inherits="IGames.Public.Jogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
<li><a href="Categorias.aspx">Categorias</a></li>
<li><a href="Forum.aspx">Fórum</a></li>
<li><a href="Login.aspx">Login</a></li>
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
<li><a href="login.aspx"><i class="material-icons left">fingerprint</i>Login</a></li>
</ul>
<a href="index.aspx" class="brand-logo">Logo</a>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  <%--<h3><asp:Label ID="NomeJogo" runat="server" Text="Nome do Jogo"></asp:Label></h3>
    <div class="row center-align from">
        <div class="col l6 offset-l3 s5 offset-s3 m7 offset-m3 ">
          <div class="card white">
              <div class="left-align">
                   <aside>
                        <i class="material-icons">favorite</i><br />
                        <i class="material-icons">info</i><br />
                        <i class="material-icons">help</i>
                    </aside>
                </div>
                <div class="center-align">
                    <i class="material-icons">grade</i><i class="material-icons">grade</i><i class="material-icons">grade</i><i class="material-icons">grade</i><i class="material-icons">grade</i><br />
                </div>
                   <iframe id="frame" src="http://browserquest.mozilla.org/" width="620px" height="400px" scrolling="no" frameborder="0"></iframe> 
          </div>
        </div>
    </div>--%>

    <h3><asp:Label ID="NomeJogo" runat="server" Text="Nome do Jogo"></asp:Label></h3>
    <div class="row center-align">
            <div class="col l6 offset-l3 s5 offset-s3 m7 offset-m3 center-align">
              <div class=" card from">
                  <div class="left-align">
                       <aside>
                            <i class="material-icons">favorite</i><br />
                            <i class="material-icons">info</i><br />
                            <i class="material-icons">help</i>
                        </aside>
                    </div>
                    <div class="center-align">
                        <i class="material-icons">grade</i><i class="material-icons">grade</i><i class="material-icons">grade</i><i class="material-icons">grade</i><i class="material-icons">grade</i><br />
                    </div>
                       <iframe id="frame" src="http://browserquest.mozilla.org/" width="620px" height="400px" scrolling="no" frameborder="0"></iframe> 
              </div>
            </div>
        </div>
     <h3 Class="center-align"><asp:Label ID="Label1" runat="server" Text="Relacionados"></asp:Label></h3>
     <h3 Class="center-align"><asp:Label ID="Label2"  runat="server" Text="Comentarios"></asp:Label></h3>
        <div class="row coment white">
            <aside class="col l1 s1 pic left">
            <%--<img src="http://lorempixel.com/100/100/" class="circle">--%>
            </aside>
            <div class="col l11 s6 offset-s3 left-align">
            <b>Nome de usuário para teste</b>
            <h6 class="right">12/04</h6><br />
            <i>18:09</i><br />
            <h6 class="message">Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur dapibus urna non dignissim. Ut pretium tempor pulvinar. Aliquam sit amet mauris laoreet, fringilla risus at, dignissim ante. Nulla turpis tellus, interdum sit amet congue lobortis, molestie et elit. In.</h6>
            </div>
        </div>
</asp:Content>