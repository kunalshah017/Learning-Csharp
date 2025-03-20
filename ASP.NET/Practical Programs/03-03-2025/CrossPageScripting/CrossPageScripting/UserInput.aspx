<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInput.aspx.cs" Inherits="CrossPageScripting.UserInput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Input</title>
</head>
<body>
    <form id="form1" runat="server" action="Output.aspx">
        <div>
            <asp:Label ID="UserNameLabel" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="UserNameInput" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="ColorLabel" runat="server" Text="Select Color:"></asp:Label>
            <asp:DropDownList ID="ColorDropDown" runat="server">
                <asp:ListItem Text="Red" Value="Red"></asp:ListItem>
                <asp:ListItem Text="Green" Value="Green"></asp:ListItem>
                <asp:ListItem Text="Blue" Value="Blue"></asp:ListItem>
                <asp:ListItem Text="Yellow" Value="Yellow" />
            </asp:DropDownList>
            <br />
            <br />

            <asp:Button ID="SubmitButton" runat="server" Text="Submit" PostBackUrl="~/Output.aspx" />
        </div>
    </form>
</body>
</html>
