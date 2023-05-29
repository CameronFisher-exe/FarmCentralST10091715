<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="FarmCentralST10091815.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Feel Free To Contact Us.</h3>
    <address>
        28 Boerie Lane<br />
        Brannasbos<br />
        Stellenbosch</address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@FarmCentral.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@FarmCentral.com</a>
    </address>
</asp:Content>
