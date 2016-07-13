<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PresentationTier.Produtos.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h3>Cadastro de Produtos</h3>
            </div>
        </div>

        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <table class="nav-justified">
                    <tr>
                        <td>&nbsp;</td>
                        <td style="width: 197px">Id do Produto</td>
                        <td>
                            <asp:TextBox ID="txtIdProduto" runat="server" AutoPostBack="True" OnTextChanged="txtIdProduto_TextChanged"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td style="width: 197px">Descrição do Produto</td>
                        <td>
                            <asp:TextBox ID="txtDescProduto" runat="server" Width="350px"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td style="width: 197px">Valor do Produto</td>
                        <td>
                            <asp:TextBox ID="txtValorProduto" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td style="width: 197px">Produto Ativo</td>
                        <td>
                            <asp:CheckBox ID="chkAtivo" runat="server" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td style="width: 197px">&nbsp;</td>
                        <td>
                            <asp:Label ID="lblMensagem" runat="server" Text="Label"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td style="width: 197px">&nbsp;</td>
                        <td>
                            <asp:Button ID="btnSalvar" runat="server" CssClass="btn active" Text="Salvar" OnClick="btnSalvar_Click" />
                            <asp:Button ID="btnAlterar" runat="server" Text="Alterar" CssClass="btn active" OnClick="btnAlterar_Click" />
                            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn active" OnClick="btnExcluir_Click" />
                            <asp:Button ID="btnListar" runat="server" Text="Listar" CssClass="btn active" OnClick="btnListar_Click" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
               

            </div>
            <div class="col-md-2"></div>
        </div>

    </div>


    
</asp:Content>
