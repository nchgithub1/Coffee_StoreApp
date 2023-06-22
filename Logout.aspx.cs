using System;

namespace CoffeeStore1
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["UserFullName"] = null;
                Session["UserId"] = null;
                Session["UserName"] = null;
                Response.Redirect("Login.aspx", false);
            }
        }
    }
}