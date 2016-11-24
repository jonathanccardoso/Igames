<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" Theme="Default" CodeBehind="Perfil.aspx.cs" Inherits="IGames.User.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">  
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
<form id="Form1" runat="server">
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
</ul>
<ul class="side-nav" id="mobile-demo">
<li>
<div class="toolbar">
<a href="Perfil.aspx" class="perfil-mobile">
<asp:Image ID="Image2" runat="server" ImageUrl="~/Images/user.png" CssClass="circle usericon" />
<asp:Label ID="Label2" runat="server" Text="Usuário" Font-Bold="true"></asp:Label>
</a>
</div>
</li>
<li><a class="search"><i class="material-icons left">search</i>Pesquisar</a></li>
<li>
<div class="input-field search-mobile">
<asp:TextBox ID="TextBox1" runat="server" CssClass="mobileSearch"></asp:TextBox>
<label for="ContentPlaceholder2_mobileSearch"><i class="material-icons">search</i></label><i class="material-icons mobile-close">close</i>
</div>
</li>
<li><a href="categorias.aspx"><i class="material-icons left">clear_all</i>Categorias</a></li>
<li><a href="forum.aspx"><i class="material-icons left">question_answer</i>Fórum</a></li>
</ul>
</form>
<a href="index.aspx" class="brand-logo">Logo</a>
</div>
</nav>
<main>
    <h3 class="center-align"><asp:Label ID="NomeJogo" runat="server" Text="Editar perfil"></asp:Label></h3>
    <div class="row">
        <div class="col l6 offset-l3 s12 m10 offset-m1">
          <div class="card white">
               <div class="card-content">
                    <form runat="server">
                        Nome:<asp:Label ID="Nome_user" runat="server" Text=""></asp:Label><br />
                        Usuário:<asp:Label ID="Usuario_user" runat="server" Text=""></asp:Label><br />
                        E-mail:<asp:Label ID="email_user" runat="server" Text=""></asp:Label><br />
                        Senha:<asp:Label ID="senha_user" runat="server" Text=""></asp:Label><br /><br />
                        <asp:LinkButton ID="EditaPerfil" runat="server" CssClass="waves-effect waves-light btn green darken-1" OnClick="EditarPerfil_Click">Editar</asp:LinkButton>
                    </form>
                </div>
            </div> 
          </div>
        </div>
</main>
</asp:Content>