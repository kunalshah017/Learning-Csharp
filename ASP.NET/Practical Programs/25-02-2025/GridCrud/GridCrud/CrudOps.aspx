<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrudOps.aspx.cs" Inherits="GridCrud.CrudOps" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student CRUD Operations</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }

        .form-group {
            margin-bottom: 15px;
        }

            .form-group label {
                display: inline-block;
                width: 120px;
            }

        .btn {
            padding: 5px 15px;
            margin-right: 10px;
        }

        .gridview {
            margin-top: 20px;
            border-collapse: collapse;
            width: 100%;
        }

            .gridview th, .gridview td {
                border: 1px solid #ddd;
                padding: 8px;
                text-align: left;
            }

            .gridview th {
                background-color: #f2f2f2;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Student Information</h2>

            <div class="form-group">
                <asp:Label ID="lblStudentName" runat="server" Text="Student Name:"></asp:Label>
                <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvStudentName" runat="server"
                    ControlToValidate="txtStudentName" ErrorMessage="Name is required"
                    ForeColor="Red" ValidationGroup="StudentGroup"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <asp:Label ID="lblMobile" runat="server" Text="Mobile Number:"></asp:Label>
                <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvMobile" runat="server"
                    ControlToValidate="txtMobile" ErrorMessage="Mobile number is required"
                    ForeColor="Red" ValidationGroup="StudentGroup"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revMobile" runat="server"
                    ControlToValidate="txtMobile" ErrorMessage="Invalid mobile number"
                    ForeColor="Red" ValidationExpression="^\d{10}$" ValidationGroup="StudentGroup"></asp:RegularExpressionValidator>
            </div>

            <div class="form-group">
                <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label>
                <asp:DropDownList ID="ddlGender" runat="server">
                    <asp:ListItem Text="Select Gender" Value=""></asp:ListItem>
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                    <asp:ListItem Text="Other" Value="Other"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvGender" runat="server"
                    ControlToValidate="ddlGender" ErrorMessage="Gender is required"
                    ForeColor="Red" ValidationGroup="StudentGroup"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group">
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn" OnClick="btnSave_Click" ValidationGroup="StudentGroup" />
                <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="btn" OnClick="btnClear_Click" CausesValidation="false" />
                <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
            </div>

            <asp:GridView ID="gvStudents" runat="server" AutoGenerateColumns="False"
                CssClass="gridview" DataSourceID="sdsStudents" DataKeyNames="StudentID">
                <Columns>
                    <asp:BoundField DataField="StudentID" HeaderText="ID" ReadOnly="True" InsertVisible="False" SortExpression="StudentID" />
                    <asp:BoundField DataField="StudentName" HeaderText="Name" SortExpression="StudentName" />
                    <asp:BoundField DataField="MobileNumber" HeaderText="Mobile" SortExpression="MobileNumber" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="sdsStudents" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                SelectCommand="SELECT * FROM Students"
                InsertCommand="INSERT INTO Students (StudentName, MobileNumber, Gender) VALUES (@StudentName, @MobileNumber, @Gender)"
                UpdateCommand="UPDATE Students SET StudentName = @StudentName, MobileNumber = @MobileNumber, Gender = @Gender WHERE StudentID = @StudentID"
                DeleteCommand="DELETE FROM Students WHERE StudentID = @StudentID" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>">
                <InsertParameters>
                    <asp:ControlParameter ControlID="txtStudentName" Name="StudentName" PropertyName="Text" />
                    <asp:ControlParameter ControlID="txtMobile" Name="MobileNumber" PropertyName="Text" />
                    <asp:ControlParameter ControlID="ddlGender" Name="Gender" PropertyName="SelectedValue" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:ControlParameter ControlID="txtStudentName" Name="StudentName" PropertyName="Text" />
                    <asp:ControlParameter ControlID="txtMobile" Name="MobileNumber" PropertyName="Text" />
                    <asp:ControlParameter ControlID="ddlGender" Name="Gender" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="hfStudentID" PropertyName="Value" Name="StudentID"></asp:ControlParameter>
                </UpdateParameters>
                <DeleteParameters>
                    <asp:Parameter Name="StudentID" Type="Int32" />
                </DeleteParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
