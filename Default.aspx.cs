using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeStore1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Session["UserFullName"] == null)
                    {
                        Response.Redirect("Login.aspx", false);
                    }
                }
            }
            catch (Exception ex)
            {
                int rowsAdded = 0;
                rowsAdded = Model.User.AddLogMessage(Session["UserName"].ToString(), ex.Message);
                Response.Redirect("Error.aspx", false);
            }
        }

        //Adding product(s) to the shopping session's cart item(s).
        protected void btnCoffee1_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAdded = Model.Product.AddCartItem(int.Parse(Session["ShoppingSessionID"].ToString()), 4, 1, Session["UserName"].ToString());
                Response.Redirect("ShoppingCart.aspx", false);
            }
            catch (Exception ex)
            {
                int rowsAdded = 0;
                rowsAdded = Model.User.AddLogMessage(Session["UserName"].ToString(), ex.Message);
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnCoffee2_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAdded = Model.Product.AddCartItem(int.Parse(Session["ShoppingSessionID"].ToString()), 5, 1, Session["UserName"].ToString());
                Response.Redirect("ShoppingCart.aspx", false);
            }
            catch (Exception ex)
            {
                int rowsAdded = 0;
                rowsAdded = Model.User.AddLogMessage(Session["UserName"].ToString(), ex.Message);
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnCoffee3_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAdded = Model.Product.AddCartItem(int.Parse(Session["ShoppingSessionID"].ToString()), 6, 1, Session["UserName"].ToString());
                Response.Redirect("ShoppingCart.aspx", false);
            }
            catch (Exception ex)
            {
                int rowsAdded = 0;
                rowsAdded = Model.User.AddLogMessage(Session["UserName"].ToString(), ex.Message);
                Response.Redirect("Error.aspx", false);
            }
        }

    }
}