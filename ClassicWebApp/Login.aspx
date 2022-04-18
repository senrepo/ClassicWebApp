<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="ClassicWebApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUserName" runat="server" Text="User Name"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" Text="Login" />
        </div>
    </form>
</body>
</html>
