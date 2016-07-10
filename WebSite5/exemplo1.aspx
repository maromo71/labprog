<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exemplo1.aspx.cs" Inherits="exemplo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Cálculo de Idade [Orientado a Objetos]</h1>
        <br />
        <br />
        Nome:<br />
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <br />
        Data de Nascimento:<br />
        <asp:Calendar ID="calDataNasc" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
        <br />
        Idade aproximada da pessoa: <asp:Label ID="lblIdade" runat="server" Text="Label"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
