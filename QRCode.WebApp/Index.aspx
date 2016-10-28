<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="QRCode.WebApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="textCode" />
            <asp:Button Text="Generate" ID="buttonGenerate" runat="server" OnClick="buttonGenerate_Click" />
            <hr />
        </div>
        <div>
            <asp:Image runat="server" ID="imgQR" />
        </div>
    </form>
</body>
</html>