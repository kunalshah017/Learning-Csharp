<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="TheaterTicketReservation.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Theater Ticket</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Select The City: "></asp:Label>
        <asp:RadioButtonList ID="CityRadio" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>Mumbai</asp:ListItem>
            <asp:ListItem>Pune</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <div runat="server" id="selectTheaterContainer">
            <asp:Label ID="Label2" runat="server" Text="Select Theater: "></asp:Label>
            <asp:DropDownList ID="theaterList" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Show Timings" Style="border: 1px solid black; padding: 10px; border-radius: 30px; color: white; background-color: black;" />
        </div>
        <br />
        <br />
        <asp:Label ID="showTimingsHeader" runat="server" Text="Show Timings" Visible="False" Style="font-size: 2rem"></asp:Label>
        <br />
        <asp:Label ID="showTimingsOutput" runat="server" ForeColor="#FF5050" Text="Label" Visible="False"></asp:Label>
    </form>
</body>
</html>
