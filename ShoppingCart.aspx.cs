using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace CoffeeStore1
{
    public partial class ShoppingCart : System.Web.UI.Page
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
                    else
                    {
                        LoadData();
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

        private void LoadData()
        {
            try
            {
                List<SelectCartItem_BySessionID_1> resCartItems = Model.Product.GetCartItembySessionID(int.Parse(Session["ShoppingSessionID"].ToString()));
                gvCartItems.DataSource = resCartItems;
                gvCartItems.DataBind();

                List<SelectCartItemGrandTotal_BySessionID_1> resCartItemsGrandTotal = Model.Product.GetCartItemGrandTotal_BySessionID(int.Parse(Session["ShoppingSessionID"].ToString()));
                if (resCartItemsGrandTotal[0].Grand_Amount > 0)
                {
                    lblGrandTotal.Text = "Grand Total: " + resCartItemsGrandTotal[0].Grand_Amount.ToString();
                }
            }
            catch (Exception ex)
            {
                int rowsAdded = 0;
                rowsAdded = Model.User.AddLogMessage(Session["UserName"].ToString(), ex.Message);
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void gvCartItems_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                GridViewRow row = (GridViewRow)gvCartItems.Rows[e.RowIndex];
                int id = Convert.ToInt32(gvCartItems.DataKeys[e.RowIndex].Value);
                int rowsdeleted = Model.Product.DeleteCartItem(id, Session["UserName"].ToString());
                LoadData();
            }
            catch (Exception ex)
            {
                int rowsAdded = 0;
                rowsAdded = Model.User.AddLogMessage(Session["UserName"].ToString(), ex.Message);
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void gvCartItems_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = (GridViewRow)gvCartItems.Rows[e.RowIndex];
                int id = Convert.ToInt32(gvCartItems.DataKeys[e.RowIndex].Value);
                string strQuantity = ((TextBox)(row.Cells[5].Controls[0])).Text;

                int rowsUpdated = Model.Product.UpdateCartItem(id, int.Parse(strQuantity), Session["UserName"].ToString());
                //Reset the edit index.
                gvCartItems.EditIndex = -1;
                LoadData();
            }
            catch (Exception ex)
            {
                int rowsAdded = 0;
                rowsAdded = Model.User.AddLogMessage(Session["UserName"].ToString(), ex.Message);
                Response.Redirect("Error.aspx", false);
            }
        }
        protected void gvCartItems_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // Set the edit index.
            gvCartItems.EditIndex = e.NewEditIndex;
            //Bind data to the GridView control.
            LoadData();
        }

        protected void gvCartItems_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            gvCartItems.EditIndex = -1;
            //Bind data to the GridView control.
            LoadData();
        }

        protected void btnContinuetoPayment_Click(object sender, EventArgs e)
        {
            string strpaymentID = "0";
            double grandAmount = 0.00;
            if (Session["PaymentID"] != null)
            {
                strpaymentID = Session["PaymentID"].ToString();
            }

            List<SelectCartItemGrandTotal_BySessionID_1> resCartItemsGrandTotal = Model.Product.GetCartItemGrandTotal_BySessionID(int.Parse(Session["ShoppingSessionID"].ToString()));
            if (resCartItemsGrandTotal[0].Grand_Amount > 0)
            {
               grandAmount = double.Parse(resCartItemsGrandTotal[0].Grand_Amount.ToString());
            }

            Response.Redirect("PaymentDetails.aspx?paymentID=" + int.Parse(strpaymentID) + "&GrandAmount=" + grandAmount.ToString(), false);
        }
    }
}