<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnCar.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
        <asp:TextBox ID="txboxEmail" runat="server" TextMode="Email" Width="173px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="tboxPassword" runat="server" TextMode="Password" Width="175px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server"  Text="Giriş Yap" Width="125px" OnClick="btnLogin_Click" />
    
    </form>
</asp:Content>
