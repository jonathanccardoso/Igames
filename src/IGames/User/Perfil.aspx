<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" Theme="Default" CodeBehind="Perfil.aspx.cs" Inherits="IGames.User.Perfil" %>
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
    <form id="Form1" runat="server">
    <h3><asp:Label ID="NomeJogo" runat="server" Text="Editar perfil"></asp:Label></h3>
    <div class="row center-align">
        <div class="col s5 offset-s3 m7 offset-m3">
          <div class="card white">
               <div class="card-content" id="card">
                <div class="estrelas">
                    Nome:<asp:Label ID="Nome_user" runat="server" Text=""></asp:Label><br />
                    Usuário:<asp:Label ID="Usuario_user" runat="server" Text=""></asp:Label><br />
                    E-mail:<asp:Label ID="email_user" runat="server" Text=""></asp:Label><br />
                    <asp:ChangePassword ID="ChangePassword1" runat="server"></asp:ChangePassword>
                    Senha:<asp:Label ID="senha_user" runat="server" Text=""></asp:Label><br /><br />
                  <asp:LinkButton ID="EditaPerfil" runat="server" CssClass="waves-effect waves-light btn green darken-1" OnClick="EditarPerfil_Click">Editar</asp:LinkButton>
                </div>
            </div> 
          </div>
        </div>
     </div>
    </form>
</asp:Content>
