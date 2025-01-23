<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuPage.aspx.cs" Inherits="Menu.MenuPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu runat="server" ID="ctl00" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem NavigateUrl="~/MenuPage.aspx" Text="Home" Value="Home"></asp:MenuItem>
                    <asp:MenuItem Text="Category" Value="Category">
                        <asp:MenuItem NavigateUrl="~/Products.aspx" Text="Products" Value="Products"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/Pricing.aspx" Text="Pricing" Value="Pricing"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/AboutUs.aspx" Text="About Us" Value="About Us"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    </form>
</body>
</html>
