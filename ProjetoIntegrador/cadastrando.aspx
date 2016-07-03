<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" Theme="Default" CodeBehind="cadastrando.aspx.cs" Inherits="ProjetoIntegrador.cadastrando" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--
    <?Php

    FAZER CONEXÃO E PASSAR PARAMETROS

	$nome=$_POST['nome'];
	$sobrenome=$_POST['sobrenome'];
	$cidade=$_POST['cidade'];
	$email=$_POST['email'];
	$senha=$_POST['senha'];
            
	$sql = mysql_query("INSERT INTO usuarios(nome, sobrenome, cidade, email, senha)
	VALUES('$nome', '$sobrenome', '$cidade', '$email', '$senha')");
	
	/*mensagem para o usuário*/
	echo "<center><h2>Cadastramento feito com sucesso!</h2>";
	echo "<br><p><a href='index.php'>Voltar a pagina de login</a></p>"; 
?>-->


    
       <h2 align="center">Cadastramento feito com sucesso!</h2>
	   <p align="center"><a href='login.aspx'>Voltar a pagina de login</a></p>

</asp:Content>
