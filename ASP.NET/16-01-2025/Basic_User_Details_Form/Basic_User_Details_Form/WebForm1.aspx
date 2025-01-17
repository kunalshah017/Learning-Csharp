<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Basic_User_Details_Form.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label><asp:TextBox runat="server" ID="name"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Mobile No: " ID="ctl06"></asp:Label><asp:TextBox runat="server" ID="mobile"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Gender: " ID="ctl10"></asp:Label><asp:DropDownList runat="server" ID="gender">
                <asp:ListItem Selected="True">Select Gender</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Others</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label runat="server" Text="Languages Known: " ID="Label2"></asp:Label><asp:TextBox ID="lang" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="showName" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="showMobile" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="showGender" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="showLang" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
