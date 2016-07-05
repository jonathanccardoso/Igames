<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" Theme="Default" CodeBehind="forum.aspx.cs" Inherits="ProjetoIntegrador.forum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
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
					<li><a href="categorias.aspx">Categorias</a></li>
					<li><a href="forum.aspx">Fórum</a></li>
					<li><a href="login.aspx">Login</a></li>
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
					<li><a href="login.aspx"><i class="material-icons left">account_circle</i>Login</a></li>
				  </ul>
				  <a href="index.aspx" class="brand-logo">Logo</a>
			</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
                <div class="card-content">
                   <div class="row">
                        <div class="col l1 s1 left">
                            <img align="left" src="http://lorempixel.com/100/100/" class="circle">
                        </div>
                        <div class="col l3 s6 offset-s2">
                            <b>Nome de usuário para teste</b><br>
                            <i>18:09</i>
                        </div>
                        <div class="col l1 offset-l7 s1">
                            <h6 class="right-align">12/04</h6>    
                        </div>
                    </div>
                    <div class="row coment">
                        <div class="col l9 offset-l1 s12">
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur dapibus urna non dignissim. Ut pretium tempor pulvinar. Aliquam sit amet mauris laoreet, fringilla risus at, dignissim ante. Nulla turpis tellus, interdum sit amet congue lobortis, molestie et elit. In.</p>   
                        </div>  
                    </div>
                </div>
            </div>
            <div class="card">
                <div class="card-content">
                    <div class="input-field col s6">
                        <form>
                            <i class="material-icons prefix">mode_edit</i>
                            <textarea id="textarea1" class="materialize-textarea"></textarea>
                            <label for="textarea1">Escreva um comentário</label>
                            <div class="row">
                                <div class="col l2 offset-l10 s7 offset-s6">
                                    <button class="btn waves-effect waves-light" type="submit" name="action">Submit
                                    <i class="material-icons right">send</i>
                                    </button>
                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
</asp:Content>
