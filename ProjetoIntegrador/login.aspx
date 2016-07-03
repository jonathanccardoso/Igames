<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" Theme="Default" CodeBehind="login.aspx.cs" Inherits="ProjetoIntegrador.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card medium">
				<div class="row">
					<div class="col l6 offset-l3 s12">
							<div class="card-content center-align">
								<h3>Login</h3>
							</div>
							<form name="loginform" method="post" runat="server">
								<div class="input-field">
									<!--<input id="email" type="email" class="validate" required="required">-->
                                    <asp:TextBox ID="email" runat="server" required="required"></asp:TextBox>
									<label for="last_name">Email</label>
								</div>
								<div class="input-field">
									<!--<input id="senha" type="password" class="validate" required="required">-->
                                    <asp:TextBox ID="senha" runat="server" Type="password" required="required"></asp:TextBox>
									<label for="last_name">Senha</label>
								</div>
								<div class="col l7 offset-l6 m3 offset-m5 s7 offset-s1">
                                    <a class="waves-effect waves-light btn yellow darken-1" href="cadastro.aspx"><i class="material-icons right">account_circle</i>Cadastre-se</a>
                                 
                                     <asp:Button ID="btnentrar" class="waves-effect waves-light btn green darken-1" runat="server" OnClick="btnentrar_Click" Text="Entrar"/>
                                    
								</div>
                                
							</form>
					</div>
				</div>
			</div>
</asp:Content>
