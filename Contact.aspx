<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CoffeeStore1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table border="0">
        <tr>
            <td>&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                <main aria-labelledby="title">

                    <h2 id="title"><%: Title %>.</h2>
                    <h3>Headquarter Office</h3>
                    <h4>For general inquiries & wholesale orders please contact our HQ located in Brea, CA. </h4>
                    <address>
                        580 N. Berry St.<br />
                        Brea, CA 92821<br />
                        <abbr title="Phone">P:</abbr>
                        (714) 784-6369
                    </address>

                    <address>
                        <strong>Support:</strong>   <a href="mailto:Support@coffestore.com">Support@coffestore.com</a><br />
                        <strong>Marketing:</strong> <a href="mailto:Marketing@coffeestore.com">Marketing@coffeestore.com</a>
                    </address>
                </main>
            </td>
        </tr>
    </table>
</asp:Content>
