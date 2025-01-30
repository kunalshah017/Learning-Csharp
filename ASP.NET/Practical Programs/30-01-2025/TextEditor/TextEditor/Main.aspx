<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="TextEditor.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display: flex; justify-content: center;">
            <asp:TextBox runat="server" OnTextChanged="User_Input_Change" ID="User_Input"></asp:TextBox>
        </div>
        <div style="display: flex; justify-content: center;">
            <asp:RadioButtonList runat="server" AutoPostBack="True" RepeatDirection="Horizontal" OnSelectedIndexChanged="Color_SelectedIndexChanged" ID="Color_Change">
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Green</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div style="display: flex; justify-content: center;">
            <asp:CheckBox ID="Bold" runat="server" Text="Bold" OnCheckedChanged="Text_Style_Change" AutoPostBack="True" />
            <asp:CheckBox ID="Italics" runat="server" Text="Italics" OnCheckedChanged="Text_Style_Change" AutoPostBack="True" />
            <asp:CheckBox ID="Underlined" runat="server" Text="Underlined" OnCheckedChanged="Text_Style_Change" AutoPostBack="True" />
        </div>
        <div class="" style="display: flex; justify-content: center;">
            <asp:Label ID="Output_Text" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
