<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentationTier._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Cadastro de Produtos</h1>
        <p class="lead">Exemplo de uma aplicação em 04 (quatro) camadas</p>
    </div>

    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-10">
            <h2>Exemplo de Aula</h2>
            <p>
                Este exemplo apresenta uma aplicação desenvolvida em quatro camadas, separando a camada de apresentação do usuário, da camada de negócios - onde se encontra toda a lógica de negócios da aplicação. Já na camada de dados temos a persistência da informação guardando e recuperando os dados do SGBD SQL Server. E a camada de entidade representa o objeto ou objetos em uso.</p>
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-1"></div>
        
    </div>

</asp:Content>
