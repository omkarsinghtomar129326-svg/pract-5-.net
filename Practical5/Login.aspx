<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AcademicLeaveManagement.Login" %>
<%-- Name: Omkar Singh | Enrollment No: 92400120399 --%>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Student Login</title>
    <style>
        body {
            font-family: Arial;
            background-color: #f2f2f2;
        }

        .container {
            width: 400px;
            margin: 80px auto;
            background: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px #aaa;
        }

        h2 {
            text-align: center;
        }

        .textbox {
            width: 100%;
            padding: 10px;
            box-sizing: border-box;
        }

        .login {
            padding: 10px 25px;
            background-color: green;
            color: white;
            border: none;
            cursor: pointer;
        }

        .error {
            color: red;
            font-weight: bold;
        }
    </style>
</head>
<body>
<form id="form1" runat="server">
    <div class="container">

        <h2>Academic Leave Management</h2>

        <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
        <br />
        <asp:TextBox ID="txtUsername" runat="server" CssClass="textbox"></asp:TextBox>
        <br /><br />

        <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
        <br />
        <asp:TextBox ID="txtPassword" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox>
        <br /><br />

        <asp:Button ID="btnLogin"
            runat="server"
            Text="Login"
            CssClass="login"
            OnClick="btnLogin_Click" />
        <br /><br />

        <asp:Label ID="lblMessage" runat="server" CssClass="error"></asp:Label>

    </div>
</form>
</body>
</html>
