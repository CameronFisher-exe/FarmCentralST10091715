<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDash.aspx.cs" Inherits="FarmCentralST10091815.EmployeeDash" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Dashboard</title>
    <style type="text/css">
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
        .center-text {
            text-align: center;
        }
        .container {
            max-width: 1200px;
            padding: 80px;
            margin: 0 auto;
            background-color: #f7f7f7;
            border-radius: 10px;
        }
        .auto-style1 {
            width: 300px;
        }
        .auto-style2 {
            width: 204px;
        }
        .auto-style3 {
            width: 369px;
        }
        .Green-text 
       {
           color: green;
       }
        .auto-style4 {
            width: 300px;
            height: 29px;
        }
        .auto-style5 {
            width: 204px;
            height: 29px;
        }
        .auto-style6 {
            height: 29px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container"><br />
            <h1 class="center-text">Welcome to the Employee Dashboard</h1>
            <h2>Add New Farmer</h2>
            <div>
                <asp:Label ID="lblErrorMessage" style="color: green" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style1">
                            <label for="txtFarmerName">Farmer Username:</label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtRegFarmerUsername" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <label for="txtFarmerAddress">Farmer Email Address:</label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtRegFarmerAddress" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <label for="txtFarmerContact">Farmer Contact:</label>
                        </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtRegFarmerContact" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            Farmer Password:</td>
                        <td class="auto-style5">
                            <asp:TextBox ID="regFarmerPassword" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td class="auto-style6"></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            Confirm Password:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="confFarmerPassword" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
            <div>
                <asp:Button ID="btnAddFarmer" runat="server" Text="Add Farmer" BackColor="#f5ce2f" Height="36px" Width="160px" OnClick="btnAddFarmer_Click"/>
            </div>

            <hr /><br />

            <h2>List of Products Supplied by Farmer</h2>
            <div>
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style1">
                            <label for="ddlFarmers">Select Farmer:</label>
                        </td>
                        <td class="auto-style3">
                            <asp:DropDownList ID="DropDownListSelectFarmer" runat="server" DataSourceID="SqlDataSource1" DataTextField="FarmerUsername" DataValueField="FarmerUsername" OnSelectedIndexChanged="DropDownListSelectFarmer_SelectedIndexChanged" Width="168px">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [FarmerUsername] FROM [Farmers]"></asp:SqlDataSource>
                            <br />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                    <br />
                    <asp:GridView ID="GridViewProducts" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
                        <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                        <asp:BoundField DataField="HarvestingDate" HeaderText="Harvesting Date" />
                    </Columns>
                    </asp:GridView>
                    <br />
                    </tr>
                    <tr>
            <td class="auto-style4">
                <label for="txtProductID">Product ID:</label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
            </td>
                <td class="auto-style6"></td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                <asp:Button ID="btnFilterProducts" runat="server" Text="Filter Products" BackColor="#f5ce2f" Height="36px" OnClick="btnFilterProducts_Click"/>
                        </td>
                        <td class="auto-style3">
                            &nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            &nbsp;</td>
                        <td class="auto-style3">
                            &nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            &nbsp;</td>
                        <td class="auto-style3">
                            &nbsp;</td>
                        <td>
                            <asp:Button ID="btnEmpLogout" runat="server" BackColor="#00CC66" OnClick="btnEmpLogout_Click" Text="Log out" />
                        </td>
                    </tr>
                </table>
            </div>
            <div>
            </div>

            <hr />
        </div>
        <footer>
            <p><span style="color: white;">&copy; <%: DateTime.Now.Year %>- Farm Central Web Application</span></p>
        </footer>
    </form>
</body>
</html>
