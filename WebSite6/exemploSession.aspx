<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exemploSession.aspx.cs" Inherits="exemploSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>
            <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
&nbsp;<asp:TextBox ID="txtNome" runat="server" Width="257px"></asp:TextBox>
&nbsp;<asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
        </h3>
    
    </div>
    </form>
</body>
</html>
