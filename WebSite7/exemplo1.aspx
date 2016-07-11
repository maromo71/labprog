<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exemplo1.aspx.cs" Inherits="exemplo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exemplo com uso de Javascript</title>
    <script src="scripts/myScript.js"></script>
</head>
<body>
    <form id="form1">
    <div>
        <h1>IMC do cliente</h1>
        <p>
            Nome da Pessoa: <br />
            <input type="text" id="textNome"  />
        </p>
        <p>
            Pessoa da Pessoa: <br />
            <input type="text" id="textPeso"  />
        </p>
        <p>
            Altura da Pessoa: <br />
            <input type="text" id="textAltura"  />
        </p>
        <p>
            <input type="submit" onclick="calcularImc();" value="Calcular" id="buttonCalcular" />
        </p>
    </div>
    </form>
</body>
</html>
