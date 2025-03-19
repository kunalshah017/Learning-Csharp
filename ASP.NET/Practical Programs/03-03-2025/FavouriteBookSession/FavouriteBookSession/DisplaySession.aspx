<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplaySession.aspx.cs" Inherits="FavouriteBookSession.DisplaySession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Your Selections</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Your Selections:</h2>
            <p>
                <strong>Favourite Book:</strong>
                <asp:Label ID="lblBook" runat="server"></asp:Label>
            </p>
            <p>
                <strong>Favourite Sport:</strong>
                <asp:Label ID="lblSport" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
