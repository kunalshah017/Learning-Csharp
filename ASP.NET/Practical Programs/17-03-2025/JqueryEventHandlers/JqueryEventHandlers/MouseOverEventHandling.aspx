<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MouseOverEventHandling.aspx.cs" Inherits="JqueryEventHandlers.MouseOverEventHandling" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mouse Over Events</title>
    <script src="https://code.jquery.com/jquery-3.7.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p color="red">
                Hello, this is a paragraph. Hover over me to see the effect.
            </p>
            <p color="yellow">
                Hello, this is a paragraph 2. Showing the same effect.
            </p>
            <p color="blue">
                Again the same effect
            </p>
        </div>
    </form>
    <script src="jquery-3.7.1.min.js"></script>
    <script>
        $(document).ready(function () {
            $("p").mouseover(function () {
                $(this).css("background-color", $(this).attr("color"));
            });
            $("p").mouseout(function () {
                $(this).css("background-color", "white");
            });
        });
    </script>
</body>
</html>
