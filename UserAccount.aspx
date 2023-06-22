<%@ Page Title="User Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserAccount.aspx.cs" Inherits="CoffeeStore1.UserAccount" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <br />
        <style>
            .content {
                width: 800px
            }
        </style>
        <table border="0">
            <tr>
                <td>&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    <asp:Panel ID="pnlUserAccount" runat="server" BorderColor="Wheat" BorderWidth="2px">
                        <table border="0" style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', 'Geneva','Verdana', 'sans-serif'; text-align: left; width: 100%; vertical-align: central;">
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="5" style="text-align: center;">
                                    <asp:Label ID="lblUserAccount" runat="server" Text="USER ACCOUNT" Font-Size="Medium" Font-Bold="true"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td style="text-align: right;">
                                    <asp:Label ID="lblUserAccountName" runat="server" Text="Username "></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td style="width: 165px">
                                    <asp:TextBox ID="txtUserAccountName" runat="server" Text="" Width="160px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" Font-Bold="true"
                                        ErrorMessage="Username is required" ControlToValidate="txtUserAccountName">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td style="text-align: right;">
                                    <asp:Label ID="lblUserAccountPassword" runat="server" Text="Password "></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td style="width: 165px">
                                    <asp:TextBox ID="txtUserAccountPassword" runat="server" Text="" Width="160px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" Font-Bold="true"
                                        ErrorMessage="Password is required" ControlToValidate="txtUserAccountPassword">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td style="text-align: right;">
                                    <asp:Label ID="Label2" runat="server" Text="First Name "></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtFirstName" runat="server" Text="" Width="160px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td style="text-align: right;">
                                    <asp:Label ID="Label3" runat="server" Text="Last Name "></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtLastName" runat="server" Text="" Width="160px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td style="text-align: right;">
                                    <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtAddress" CssClass="content" MaxLength="160" Width="200px" runat="server" Text=""></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td style="text-align: right;">
                                    <asp:Label ID="Label6" runat="server" Text="City"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtCity" Width="160px" runat="server" Text=""></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td style="text-align: right;">
                                    <asp:Label ID="Label1" runat="server" Text="State"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtState" Width="40px" runat="server" Text=""></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>

                            <tr>
                                <td>&nbsp;</td>
                                <td style="text-align: right;">
                                    <asp:Label ID="Label4" runat="server" Text="Zip Code"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtZipCode" Width="100px" runat="server" Text=""></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td style="text-align: right;">
                                    <asp:Label ID="lblTelephone" runat="server" Text="Phone "></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="txtTelephone" runat="server" Text="" Width="160px"></asp:TextBox>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="3" style="text-align: center; vertical-align: middle;">&nbsp;
                                </td>
                                <td style="text-align: left; vertical-align: auto;">
                                    <asp:Button ID="btnSave" runat="server" Text="SUBMIT" OnClick="btnSave_Click" />
                                    &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnClear" runat="server" Text="CLEAR" OnClick="btnClear_Click" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="5">
                                    <asp:Label ID="lblMessage" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;
                                </td>
                                <td>&nbsp;
                                </td>
                                <td>&nbsp;
                                </td>
                                <td style="text-align: left; vertical-align: middle;">
                                    <a href="UserAccount.aspx?NewUser=Y">New User Account</a>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="5">&nbsp;
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </main>
</asp:Content>
