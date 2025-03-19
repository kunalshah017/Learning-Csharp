<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FavouriteBook.aspx.cs" Inherits="FavouriteBookSession.FavouriteBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Select Favourite Book</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Select your favourite book:</h2>
            <asp:DropDownList ID="ddlBooks" runat="server">
                <asp:ListItem Text="-- Select a Book --" Value="" />
                <asp:ListItem Text="Harry Potter" Value="Harry Potter" />
                <asp:ListItem Text="Lord of the Rings" Value="Lord of the Rings" />
                <asp:ListItem Text="To Kill a Mockingbird" Value="To Kill a Mockingbird" />
                <asp:ListItem Text="Pride and Prejudice" Value="Pride and Prejudice" />
                <asp:ListItem Text="The Great Gatsby" Value="The Great Gatsby" />
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
