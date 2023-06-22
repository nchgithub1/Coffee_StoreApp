using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeStore1
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserFullName"]!=null)
                {
                    lblLoggedUser.Text = "Hello " + Session["UserFullName"].ToString();
                    pnlGuestPanel.Visible = false;
                    pnlLoggedPanel.Visible = true;
                }
                else
                {
                    lblGuestUser.Text = "Hello guest!";
                    pnlGuestPanel.Visible = true;
                    pnlLoggedPanel.Visible = false;
                }
            }
        }
    }
}