﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListCar.aspx.cs" Inherits="OnCar.ListCar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="nav-justified">
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("BrandName") %>'></asp:Label>

                            &nbsp;
                          <asp:Label ID="Label1" runat="server" Text='<%# Eval("CarModel") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 20px"></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="Image1" runat="server" Height="248px" ImageUrl='<%# Eval("CarPhoto") %>' Width="985px" />
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 20px">
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("CarFuelType") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text='<%# Eval("CarDescription") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 20px">
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("CarSeller") %>'></asp:Label>
                            &nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("CarContact") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text='<%# Eval("CarPrice") %>'></asp:Label>
                        </td>
                    </tr>
                     <tr>
                        <td>
                            <a></a>
                            <asp:Label ID="Label8" runat="server" Text='<%# Eval("CarPrice") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>

    </form>
</asp:Content>
