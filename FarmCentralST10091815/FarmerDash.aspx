<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FarmerDash.aspx.cs" Inherits="FarmCentralST10091815.FarmerDash" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Farmer Dashboard</title>
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
        .profile-table {
            width: 100%;
        }
        .profile-table td {
            padding: 5px;
        }
        .profile-label {
            font-weight: bold;
        }
        .auto-style3 {
            font-weight: bold;
            width: 171px;
        }
        .auto-style6 {
            width: 171px;
        }
        .auto-style7 {
            width: 110px;
        }
        .auto-style8 {
            width: 200px;
        }
        .auto-style9 {
            width: 110px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 class="center-text">Welcome to Your Farmer Dashboard</h1>
            <h2>Your Profile</h2>
            <div>
                <asp:Label ID="lblErrorMessage" style="color: green" runat="server" Text=""></asp:Label>
            </div>
            <table class="profile-table">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style8">
                        <strong>Product Category</strong>:</td>
                    <td class="auto-style7">
                        <strong>Vegetables</strong></td>
                    <td class="auto-style6">
                        <strong>Fruits</strong></td>
                    <td>
                        <strong>Meat</strong></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style8">
                        Product ID:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtVegetableID" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtFruitID" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMeatID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style8">
                        Product Name:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtVegetableName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtFruitName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMeatName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style8">
                        Harvesting Date:</td>
                    <td class="auto-style7">
                        <asp:Calendar ID="CalendarVegetable" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="200px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                    </td>
                    <td class="auto-style6">
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="200px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                    </td>
                    <td>
                        <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="200px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style8">
                        &nbsp;</td>
                    <td class="auto-style9">
                        <asp:Button ID="btnSendVegetable" runat="server" BackColor="#00CC66" OnClick="btnSendVegetable_Click" Text="Send to Database" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnSendFruit" runat="server" BackColor="#00CC66" OnClick="btnSendFruit_Click" Text="Send to Database" />
                    </td>
                    <td>
                        <asp:Button ID="btnSendMeat" runat="server" BackColor="#00CC66" OnClick="btnSendMeat_Click" Text="Send to Database" />
                    </td>
                </tr>
            </table>

            <hr />

            <h2>Your Products</h2>
            <!-- Add a display of products -->

            <hr />
        </div>
        <footer>
            <p class="center-text"><span style="color: white;">&copy; <%: DateTime.Now.Year %>- Farm Central Web Application</span></p>
        </footer>
    </form>
</body>
</html>
