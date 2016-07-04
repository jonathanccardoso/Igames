<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true"Theme="Default" CodeBehind="cadastro.aspx.cs" Inherits="ProjetoIntegrador.cadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <div class="nav-wrapper">
        <a href="index.aspx" class="brand-logo center">Logo</a>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
					<div class="card large">
					<div class="col l6 offset-l3 s12">
							<div class="card-content center-align">
								<h3>Cadastre-se</h3>
							</div>
                            <form id="form1" runat="server">
								<div class="input-field">
									<!---<input id="nome" type="text" class="validate" required="required">-->
                                    <asp:TextBox ID="nome" runat="server" type="text" required="required"></asp:TextBox>

									<label for="last_name">Nome</label></div>
								<div class="input-field">
									 <!---<input id="email" type="email" class="validate" required="required">  -->
                                     <asp:TextBox ID="email" runat="server" type="email" required="required"></asp:TextBox>
									<label for="last_name">Email</label>
								</div>
								<div class="input-field">
									<!--<input id="senha" type="password" class="validate" required="required">-->
                                    <asp:TextBox ID="senha" runat="server" type="password" required="required"></asp:TextBox>
									<label for="last_name">Senha</label>
								</div>
								<div class="input-field">
                                    <asp:TextBox ID="confsenha" runat="server" type="password" required="required"></asp:TextBox>
									<label for="last_name">Confirmar senha</label>
								</div>
								<div class="col l7 offset-l7 m4 offset-m9 s7 offset-s6">
								<asp:LinkButton ID="btnlogin" runat="server" CssClass="waves-effect waves-light btn green darken-1" OnClick="btncadastro_Click">
									<i class="material-icons right">assignment_ind</i>Cadastrar
								</asp:LinkButton>
                                </div>
                            </form>
						</div>
				</div>
			</div>
</asp:Content>
