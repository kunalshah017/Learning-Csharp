<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Country_Capital.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Country: "></asp:Label><asp:DropDownList runat="server" ID="selectCountry">
                <asp:ListItem Selected="True">Select Country</asp:ListItem>
                <asp:ListItem Value="Delhi">India</asp:ListItem>
                <asp:ListItem Value="Islamabad">Pakistan</asp:ListItem>
                <asp:ListItem Value="Kabul">Afghanistan</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="View Capital" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="showCapital" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
