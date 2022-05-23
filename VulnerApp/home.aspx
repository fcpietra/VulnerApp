<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="VulnerApp.home" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1><asp:Label ID="lblBienvenido" runat="server" Text="Bienvenido"></asp:Label></h1>
    <asp:GridView ID="gvResultado" runat="server" CssClass="table"></asp:GridView>

</asp:Content>
