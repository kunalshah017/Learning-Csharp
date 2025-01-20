<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginSuccess.aspx.cs" Inherits="SimpleLogin.LoginSuccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Login Successful"></asp:Label>

        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" />

    </form>
</body>
</html>
