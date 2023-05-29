<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="FarmCentralST10091815.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Login</title>
    <style>
        body {
            background-color: #f7f7f7;
            background-image: url('Images/FarmBackground.jpg');
            background-repeat: no-repeat;
            background-size: cover;
            font-family: Arial, sans-serif;
            justify-content: center;
            display: flex;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .container {
            max-width: 1600px;
            padding: 80px;
            background-color: #f7f7f7; /*#FFD68A*/
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            border-radius: 10px;
        }
        .form-group {
            margin-bottom: 50px;
        }
        .form-label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
        }
        .form-control {
            width: 80%;
            height: 30px;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            background-color: #fff;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
            transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s;
        }
        .form-control:focus {
            border-color: #66afe9;
            outline: 0;
            box-shadow: 0 0 6px rgba(102, 175, 233, 0.5);
        }
        .btn {
            display: inline-block;
            padding: 6px 12px;
            margin-bottom: 0;
            font-size: 14px;
            font-weight: normal;
            line-height: 1.42857143;
            text-align: center;
            white-space: nowrap;
            vertical-align: middle;
            cursor: pointer;
            border: 1px solid transparent;
            border-radius: 4px;
            user-select: none;
        }
        .btn-primary {
            color: #fff;
            background-color: #337ab7;
            border-color: #2e6da4;
        }
        .auto-style1 {
            font-weight: normal;
        }
        .auto-style2 {
            display: block;
            margin-bottom: 5px;
        }
        .auto-style3 {
            text-align: left;
        }

        .icon-User {
            display: inline-block;
            width: 12px;
            height: 12px;
            margin-right: 5px;
            background-image: url(Icons/user-regular.svg); 
            background-size: cover;
        }
        .icon-Lock {
            display: inline-block;
            width: 12px;
            height: 12px;
            margin-right: 5px;
            background-image: url(Icons/lock-solid.svg); 
            background-size: cover;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2 class="auto-style3"><b>Employee Login</b></h2><br/>
            <div>
                <asp:Label ID="lblErrorMessage" style="color: green" runat="server" Text=""></asp:Label>
            </div>
            <div class="form-group">
                <label for="EmpUsernameText" class="auto-style2"><span class="icon-User"></span> Enter username:</label>
                <asp:TextBox ID="txtEmpUsername" runat="server" CssClass="form-control" placeholder="Username"></asp:TextBox>
            </div>

            <div class="form-group">
                <label for="EmpPasswordText" class="auto-style2"><span class="icon-Lock"></span> Enter password:</label>
                <asp:TextBox ID="txtEmpPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password"></asp:TextBox>
            </div>

            <asp:Button ID="btnEmpLogin" runat="server" OnClick="EmpLoginButton_Click" Text="Login" CssClass="btn btn-primary" BackColor="#f5ce2f" />
        </div>
        <footer>
            <p><span style="color: white;">&copy; <%: DateTime.Now.Year %>- Farm Central Web Application</span></p>
        </footer>
    </form>
</body>
</html>
