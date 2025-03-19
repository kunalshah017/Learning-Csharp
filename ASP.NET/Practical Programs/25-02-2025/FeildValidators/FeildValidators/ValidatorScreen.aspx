<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidatorScreen.aspx.cs" Inherits="FeildValidators.ValidatorScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <style>
        .error {
            color: red;
        }

        .form-group {
            margin-bottom: 15px;
        }

        .form-container {
            width: 100%;
            height: 100dvh;
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            padding: 20px;
            border: 1px solid #ddd;
            margin: 0 auto;
        }

        .form-label {
            display: inline-block;
            width: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>User Registration</h2>

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="error" HeaderText="Please correct the following errors:" />

            <div class="form-group">
                <span class="form-label">Username:</span>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqUsername" runat="server" ControlToValidate="txtUsername"
                    ErrorMessage="Username is required" CssClass="error" Display="Dynamic">*</asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <span class="form-label">Password:</span>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqPassword" runat="server" ControlToValidate="txtPassword"
                    ErrorMessage="Password is required" CssClass="error" Display="Dynamic">*</asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <span class="form-label">Confirm Password:</span>
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword"
                    ErrorMessage="Confirm Password is required" CssClass="error" Display="Dynamic">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="compPassword" runat="server" ControlToValidate="txtConfirmPassword"
                    ControlToCompare="txtPassword" ErrorMessage="Passwords do not match" CssClass="error" Display="Dynamic">*</asp:CompareValidator>
            </div>

            <div class="form-group">
                <span class="form-label">Age:</span>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqAge" runat="server" ControlToValidate="txtAge"
                    ErrorMessage="Age is required" CssClass="error" Display="Dynamic">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rangeAge" runat="server" ControlToValidate="txtAge"
                    ErrorMessage="Age must be between 18 and 40" MinimumValue="18" MaximumValue="40" Type="Integer"
                    CssClass="error" Display="Dynamic">*</asp:RangeValidator>
            </div>

            <div class="form-group">
                <span class="form-label">Country/State:</span>
                <asp:DropDownList ID="ddlCountry" runat="server">
                    <asp:ListItem Text="--Select--" Value="" />
                    <asp:ListItem Text="USA" Value="USA" />
                    <asp:ListItem Text="Canada" Value="Canada" />
                    <asp:ListItem Text="India" Value="India" />
                    <asp:ListItem Text="UK" Value="UK" />
                    <asp:ListItem Text="Australia" Value="Australia" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="reqCountry" runat="server" ControlToValidate="ddlCountry"
                    ErrorMessage="Country/State is required" CssClass="error" Display="Dynamic" InitialValue="">*</asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <span class="form-label">Email ID:</span>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqEmail" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Email is required" CssClass="error" Display="Dynamic">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="regexEmail" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Invalid email format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    CssClass="error" Display="Dynamic">*</asp:RegularExpressionValidator>
            </div>

            <div class="form-group">
                <span class="form-label">Mobile Number:</span>
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqMobile" runat="server" ControlToValidate="txtMobile"
                    ErrorMessage="Mobile number is required" CssClass="error" Display="Dynamic">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="regexMobile" runat="server" ControlToValidate="txtMobile"
                    ErrorMessage="Mobile number must be 10 digits" ValidationExpression="^[0-9]{10}$"
                    CssClass="error" Display="Dynamic">*</asp:RegularExpressionValidator>
            </div>

            <div class="form-group">
                <asp:Button ID="btnSubmit" runat="server" Text="Register" OnClick="btnSubmit_Click" />
            </div>

            <div>
                <asp:Label ID="lblMessage" runat="server" EnableViewState="false"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
