<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exemplo3.aspx.cs" Inherits="exemplo3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="pnlBusca" runat="server" Width="433px">
            <h2>Sistema de Busca</h2>
            <br />
            <br />
            Digite uma palavra:
            <asp:TextBox ID="txtBusca" runat="server" Width="226px"></asp:TextBox>
            <asp:Button ID="btnBusca" runat="server" OnClick="btnBusca_Click" Text="Buscar" />
            <br />
        </asp:Panel>
    
    </div>
        <asp:Panel ID="pnlResult" runat="server" Height="252px" style="margin-top: 45px" Visible="False" Width="432px">
            <h3>Resultado da Busca:</h3>
            <br />
            <br />
            1.<br /> 2.<br /> 3.<br /> 4.<br /> 5.<br />
            <asp:Button ID="btnNova" runat="server" OnClick="btnNova_Click" Text="Nova Busca" Width="139px" />
        </asp:Panel>
    </form>
</body>
</html>
