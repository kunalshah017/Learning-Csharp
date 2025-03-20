<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Output.aspx.cs" Inherits="CrossPageScripting.Output" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Output</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>User Information</h2>
            <asp:Label ID="OutputLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="BackLink" runat="server" NavigateUrl="~/UserInput.aspx">Back to Input Page</asp:HyperLink>
        </div>
    </form>
</body>
</html>
