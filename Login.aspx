<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CoffeeStore1.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <br />
        <table border="0">
            <tr>
                <td>&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    <asp:Panel ID="pnlLogin"  runat="server" BorderColor="Wheat" BorderWidth="2px">
                        <table border="0" style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', 'Geneva','Verdana', 'sans-serif'; text-align: left; width: 410px; vertical-align: central;">
                            <tr>
                                <td colspan="4">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;
                                </td>
                                <td>&nbsp;
                                </td>
                                <td style="text-align: center;">
                                    <asp:Label ID="lblUserLogin" runat="server" Text="USER LOGIN" Font-Size="Medium" Font-Bold="true"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="4">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td style="text-align: right;">
                                    <asp:Label ID="lblUserName" runat="server" Text="Username"></asp:Label>&nbsp;
                                </td>

                                <td style="width: 165px">
                                    <asp:TextBox ID="txtUserName" runat="server" Text="" Width="160px" MaxLength="50"></asp:TextBox>

                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" Font-Bold="true"
                                        ErrorMessage="Username is required" ControlToValidate="txtUserName">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="4">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td style="text-align: right;">
                                    <asp:Label ID="lblUserPassword" runat="server" Text="Password"></asp:Label>&nbsp;
                                </td>
                                <td style="width: 165px">
                                    <asp:TextBox ID="txtUserPassword" runat="server" Text="" Width="160px" TextMode="Password" MaxLength="110"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" Font-Bold="true"
                                        ErrorMessage="Password is required" ControlToValidate="txtUserPassword">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="4">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;
                                </td>
                                <td>&nbsp;
                                </td>
                                <td style="text-align: center; vertical-align: middle;">
                                    <asp:Button ID="btnLogin" runat="server" Text="LOGIN" OnClick="btnLogin_Click" />
                                </td>
                                <td>&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;
                                </td>
                                <td>&nbsp;
                                </td>
                                <td style="text-align: center; vertical-align: middle;">
                                    <a href="UserAccount.aspx?NewUser=Y">New User Account</a>
                                </td>
                                <td>&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4">
                                    <asp:Label ID="lblMessage" Font-Bold="true" ForeColor="Red" runat="server" Text=""></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </main>
</asp:Content>
