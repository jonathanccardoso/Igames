<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Busca.aspx.cs" Theme="Default" Inherits="IGames.Public.Busca" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<nav>
<div class="nav-wrapper">  
<a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
<ul class="right hide-on-med-and-down">
<li><a class="show-search"><i class="material-icons">search</i></a></li>
<li> 
<!---
    o enter esta ok
    falta mostrar o resultado na query(consulta)
    -->

<%--<form id= "form1" runat="server" method="post" action="Busca.aspx"> 
    <div class="input-field search-desktop">
        <%--<asp:TextBox ID="search" runat="server" style="background-color:black"></asp:TextBox>--%>
        <%--<input id="search" type="search">
        <label for="search" style="background-color:black"><i class="material-icons">search</i></label><i style="background-color:black" class="material-icons close">close</i>    
    </div>
</form>--%>

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
</nav>
<main>
    <form runat="server" action="Busca.aspx" method="post">
      <div class="center">
          <asp:TextBox ID="TextBusca" runat="server" Class="center-align"></asp:TextBox>
          <asp:Button ID="busca" runat="server" Text="Busca" OnClick="Busca_Click"></asp:Button>
       </div>
    </form>
</main>
</asp:Content>
