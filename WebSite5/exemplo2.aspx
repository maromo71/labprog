<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exemplo2.aspx.cs" Inherits="exemplo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>Selecione a Fruta</h3>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Font-Size="Medium" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="261px">
            <asp:ListItem>Banana</asp:ListItem>
            <asp:ListItem>Melão</asp:ListItem>
            <asp:ListItem>Melancia</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="lblFruta" runat="server"></asp:Label>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="É Fruta Fresca ?" />
        <br />
        <br />
        <asp:Label ID="lblFrutaFresca" runat="server"></asp:Label>
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="93px" SelectionMode="Multiple" Width="248px"></asp:ListBox>
        <asp:Button ID="btnSelecionar" runat="server" OnClick="btnSelecionar_Click" Text="Selecionar Moeda" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblMoeda" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
