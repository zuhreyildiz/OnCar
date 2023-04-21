<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ContactPage.aspx.cs" Inherits="OnCar.ContactPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:TextBox ID="tboxName" runat="server" ToolTip="İsminizi giriniz"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="tboxMail" runat="server" ToolTip="Mail adresinizi giriniz"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="tboxMessage" runat="server" Height="212px" TextMode="MultiLine" ToolTip="Mesajınızı yazınız" Width="363px"></asp:TextBox>
        <br />
        <asp:Button ID="BntSend" runat="server" OnClick="BntSend_Click" Text="Mesajı Gönder" Width="135px" />
        <br />
        
        
    </form>
</asp:Content>
