<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BoxAnimations.aspx.cs" Inherits="BoxAnimationsWithJquery.BoxAnimations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            height: 100vh;
            width: 100vw;
        }

        form {
            display: flex;
            flex-direction: column;
            height: 100%;
            width: 100%;
        }

        .animation-container {
            height: 90%;
            width: 100%;
            position: relative;
            overflow: hidden;
        }

        .animated-box {
            height: 300px;
            width: 300px;
            background-color: red;
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            transition: all ease 1s;
        }
    </style>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px">
            <input type="button" value="Hide" id="btnHide" />
            <input type="button" value="Show" id="btnShow" />
            <input type="button" value="Animate" id="btnAnimate" />
        </div>
        <div class="animation-container">
            <div id="box" class="animated-box"></div>
        </div>
    </form>
    <script>
        $(document).ready(function () {
            $("#btnHide").click(function () {
                $("#box").css({ "opacity": "0" });
            });
            $("#btnShow").click(function () {
                $("#box").css({ "opacity": "1" });
            });
            $("#btnAnimate").click(function () {
                $("#box").animate({
                    top: `${1 + Math.floor(Math.random() * 80)}%`,
                    left: `${1 + Math.floor(Math.random() * 80)}%`,
                }, 1000);
            });
        });
    </script>
</body>
</html>
