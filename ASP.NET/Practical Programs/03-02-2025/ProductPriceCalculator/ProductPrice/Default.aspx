<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProductPrice.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Price Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Product Price Calculator</h2>

            <asp:Label ID="error" runat="server" Visible="false"></asp:Label>
            
            <!-- Product Dropdown -->
            <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
                <asp:ListItem Text="Select a Product" Value="0"></asp:ListItem>
                <asp:ListItem Text="Water Bottle" Value="50"></asp:ListItem>
                <asp:ListItem Text="Book" Value="30"></asp:ListItem>
                <asp:ListItem Text="Pens" Value="5"></asp:ListItem>
            </asp:DropDownList>

            <asp:Image ID="imgProduct" runat="server" Width="300px" />

            <br /><br />

            <asp:Label ID="lblFinalCost" runat="server" Text="Final Cost: $0.00"></asp:Label>

            <br /><br />

            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>

            <asp:Button ID="btnCalculate" runat="server" Text="Calculate Total" OnClick="btnCalculate_Click" />

            <br /><br />

            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price: $0.00"></asp:Label>
        </div>
    </form>
</body>
</html>