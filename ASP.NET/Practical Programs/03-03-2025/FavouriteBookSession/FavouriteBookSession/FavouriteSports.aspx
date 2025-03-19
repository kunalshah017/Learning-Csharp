<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FavouriteSports.aspx.cs" Inherits="FavouriteBookSession.FavouriteSports" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Select Favourite Sports</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Select your favourite sport:</h2>
            <asp:DropDownList ID="ddlSports" runat="server">
                <asp:ListItem Text="-- Select a Sport --" Value="" />
                <asp:ListItem Text="Football" Value="Football" />
                <asp:ListItem Text="Basketball" Value="Basketball" />
                <asp:ListItem Text="Cricket" Value="Cricket" />
                <asp:ListItem Text="Tennis" Value="Tennis" />
                <asp:ListItem Text="Swimming" Value="Swimming" />
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
