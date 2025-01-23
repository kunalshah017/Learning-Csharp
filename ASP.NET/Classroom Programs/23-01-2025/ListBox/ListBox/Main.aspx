<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ListBox.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="List Value: "></asp:Label><asp:TextBox runat="server" ID="ListItemInput"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add Item" OnClick="Button1_Click" />
            <br />
            <asp:ListBox runat="server" ID="CustomListBox" SelectionMode="Multiple" AutoPostBack="True" OnSelectedIndexChanged="CustomListBox_IndexChange"></asp:ListBox>
            <br />
            <asp:Label runat="server" Text="Selected Values: " ID="SelectedItems"></asp:Label>
        </div>
    </form>
</body>
</html>
