<%@ Page Title="Shopping Cart" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="CoffeeStore1.ShoppingCart" %>

<%@ Register Assembly="DevExpress.Web.v22.2, Version=22.2.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table border="0">
        <tr>
            <td>&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                <main aria-labelledby="title">
                    <asp:Panel ID="pnlShoppingCart" runat="server">
                        <table border="0" style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', 'Geneva','Verdana', 'sans-serif'; text-align: center; width: 965px; vertical-align: central;">
                            <tr>
                                <td>&nbsp;
                                </td>
                            </tr>
                            <tr style="border: solid; border-block-start-width: 1px;">
                                <td style="text-align: left; background-color: antiquewhite">
                                    <asp:Label ID="lblShoppingCart" runat="server" Text="Shopping Cart" Font-Bold="true"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView ID="gvCartItems" runat="server" AutoGenerateColumns="false" DataKeyNames="CartItemID" AllowSorting="true" Width="964px"
                                        OnRowEditing="gvCartItems_RowEditing" OnRowCancelingEdit="gvCartItems_RowCancelingEdit" AllowPaging="true"
                                        OnRowDeleting="gvCartItems_RowDeleting" OnRowUpdating="gvCartItems_RowUpdating">
                                        <Columns>
                                            <asp:CommandField ItemStyle-Width="120px" ShowDeleteButton="true" ShowEditButton="true" HeaderStyle-BackColor="LightBlue" HeaderStyle-ForeColor="Black" />
                                            <asp:BoundField DataField="name" HeaderText="Product Name" ReadOnly="true" ItemStyle-Width="330px" HeaderStyle-BackColor="LightBlue" HeaderStyle-ForeColor="Black" HeaderStyle-Font-Bold="true" HeaderStyle-VerticalAlign="Middle" HeaderStyle-HorizontalAlign="Center" SortExpression="name" />
                                            <asp:BoundField DataField="description" HeaderText="Product Description" ItemStyle-Width="330px" HeaderStyle-BackColor="LightBlue" HeaderStyle-ForeColor="Black" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" SortExpression="description" />
                                            <asp:BoundField DataField="category" HeaderText="Category" ItemStyle-Width="80px" HeaderStyle-BackColor="LightBlue" HeaderStyle-ForeColor="Black" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" SortExpression="category" />
                                            <asp:BoundField DataField="amount" HeaderText="Price" ItemStyle-Width="80px" HeaderStyle-BackColor="LightBlue" HeaderStyle-ForeColor="Black" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center" ReadOnly="true" SortExpression="amount" />
                                            <asp:BoundField DataField="quantity" HeaderText="Quantity" ItemStyle-Width="80px" HeaderStyle-BackColor="LightBlue" HeaderStyle-ForeColor="Black" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center" SortExpression="quantity" />
                                            <asp:BoundField DataField="TotalAmount" ItemStyle-Width="80px" HeaderStyle-BackColor="LightBlue" HeaderStyle-ForeColor="Black" HeaderStyle-Font-Bold="true" HeaderStyle-HorizontalAlign="Center" HeaderText="Amount" ReadOnly="true" SortExpression="TotalAmount" />
                                        </Columns>
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 914px; text-align: right; vertical-align: bottom;">
                                    <asp:Label ID="lblGrandTotal" Font-Bold="true" runat="server" Text=""></asp:Label>
                                </td>
                            </tr>

                        </table>
                        <br />
                        <table border="0" style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', 'Geneva','Verdana', 'sans-serif'; text-align: center; width: 265px; vertical-align: central;">
                            <tr>
                                <td colspan="2">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3" style="text-align: left; vertical-align: text-bottom;">
                                    <asp:Button ID="btnContinuetoPayment" runat="server" Text="Continue to Payment" OnClick="btnContinuetoPayment_Click" Font-Bold="true" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </main>
            </td>
        </tr>
    </table>
</asp:Content>
