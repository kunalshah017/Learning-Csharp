<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="File_Upload.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload runat="server" ID="fileUpload"></asp:FileUpload>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Upload File" OnClick="Button1_Click" />
            <br />
            
        </div>
    </form>
</body>
</html>
