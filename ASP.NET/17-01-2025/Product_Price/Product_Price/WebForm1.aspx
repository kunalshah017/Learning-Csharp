<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Product_Price.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Select Product: "></asp:Label><asp:DropDownList runat="server" ID="selectProduct">
                <asp:ListItem Value="0">Select Product</asp:ListItem>
                <asp:ListItem Value="10">Pen</asp:ListItem>
                <asp:ListItem Value="2">Paper</asp:ListItem>
                <asp:ListItem Value="5">Pencil</asp:ListItem>
                <asp:ListItem Value="20">Stickers</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Quantity: "></asp:Label><asp:TextBox ID="quantity" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Calculate Total Price" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="totalPrice" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
