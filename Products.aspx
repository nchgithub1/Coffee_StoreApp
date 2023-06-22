<%@ Page Title="Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="CoffeeStore1.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table border="0">
        <tr>
            <td>&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                <main aria-labelledby="title">
                    <div class="container">
                        <section class="row" aria-labelledby="aspnetTitle">
                            <p class="lead">
                                EXCLUSIVE COFFEE BLENDS
                            </p>
                        </section>
                    </div>
                    <table border="0" width="100%" style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif">
                        <tr>
                            <td style="vertical-align: top; text-align: left; width: 30%;">
                                <img src="Images/coffee1.png" style="width: 100%; height: 100%;" />
                            </td>
                            <td style="vertical-align: top; text-align: left; width: 30%;">
                                <img src="Images/coffee2.png" style="width: 100%; height: 100%;" />
                            </td>
                            <td style="vertical-align: top; text-align: left; width: 30%;">
                                <img src="Images/coffee3.png" style="width: 100%; height: 100%;" />
                            </td>
                        </tr>
                        <tr>
                            <td style="vertical-align: middle; text-align: center; width: 30%;">
                                <asp:Label ID="lblCoffee1" runat="server" Text="$25.00" Font-Bold="true"></asp:Label>
                            </td>
                            <td style="vertical-align: middle; text-align: center; width: 30%;">
                                <asp:Label ID="lblCoffee2" runat="server" Text="$30.00" Font-Bold="true"></asp:Label>
                            </td>
                            <td style="vertical-align: middle; text-align: center; width: 30%;">
                                <asp:Label ID="lblCoffee3" runat="server" Text="$36.00" Font-Bold="true"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="vertical-align: middle; text-align: center; width: 30%;">
                                <asp:Button ID="btnCoffee1" runat="server" Text="Buy" Font-Bold="true" OnClick="btnCoffee1_Click" />
                            </td>
                            <td style="vertical-align: middle; text-align: center; width: 30%;">
                                <asp:Button ID="btnCoffee2" runat="server" Text="Buy" Font-Bold="true" OnClick="btnCoffee2_Click" />
                            </td>
                            <td style="vertical-align: middle; text-align: center; width: 30%;">
                                <asp:Button ID="btnCoffee3" runat="server" Text="Buy" Font-Bold="true" OnClick="btnCoffee3_Click" />
                            </td>
                        </tr>
                    </table>
                </main>
            </td>
        </tr>
    </table>
</asp:Content>
