<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VulnerApp.Login" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Login ID="BadLogin" runat="server" OnAuthenticate="BadLogin_Authenticate" PasswordRecoveryText="Recuperar clave" PasswordRecoveryUrl="~/RecuperarClave.aspx"></asp:Login>
</asp:Content>
