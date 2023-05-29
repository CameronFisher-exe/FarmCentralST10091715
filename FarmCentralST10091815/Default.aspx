<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FarmCentralST10091815._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
       body 
       {
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
       .white-text 
       {
           color: white;
       }

    </style>
    <div class="jumbotron text-center">
        <h1><strong>Welcome</strong></h1>
        <p class="lead"><strong>Farm Central stock management website. Track incoming and outgoing stock.</strong></p>
        <p class="lead">Farm Central: Your partner in stock management for a thriving farm.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2><b><span style="color: white;">Employee</span></b></h2>
            <p><span style="color: white;">Login for Employees.</span></p>
            <p>
                <a href="Employee.aspx" class="btn btn-default">Login &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2><b><span style="color: white;">Farmer</span></b></h2>
            <p><span style="color: white;">Login for Farmers.</span></p>
            <p>
                <a href="Farmer.aspx" class="btn btn-default">Login &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>
