using System;
using System.Collections.Generic;
using CoffeeStore1.Model;
namespace CoffeeStore1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    txtUserName.Text = txtUserPassword.Text = lblMessage.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                int rowsAdded = 0;
                if (Session["UserName"] != null)
                {
                    rowsAdded = Model.User.AddLogMessage(Session["UserName"].ToString(), ex.Message);
                }
                else
                {
                    rowsAdded = Model.User.AddLogMessage(txtUserName.Text, ex.Message);
                }
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username, userpass, encryptuserpass;
                lblMessage.Text = username = userpass = encryptuserpass = string.Empty;
                username = txtUserName.Text.Trim();
                userpass = txtUserPassword.Text.Trim(); //adminUser1!

                encryptuserpass = encrypt_decrypt.Encode(userpass);
                List<SelectUserValidYN_1> isUserValid = Model.User.SelectUserValidYN(username, encryptuserpass);
                if (isUserValid.Count > 0)
                {
                    var t = isUserValid[0];
                    if (t != null)
                    {
                        Session["UserFullName"] = t.first_name + " " + t.last_name;
                        Session["UserId"] = t.id.ToString();
                        Session["UserName"] = t.username;
                    }

                    int sessionID = 0;
                    sessionID = Model.User.AddShoppingSession(int.Parse(Session["UserId"].ToString()), (float)0.00, Session["UserName"].ToString());
                    if (sessionID > 0)
                    {
                        Session["ShoppingSessionID"] = sessionID;
                    }

                    Response.Redirect("Default.aspx", false);
                }
                else
                {
                    lblMessage.Text = "User Login information is invalid. Please try again.";
                }
            }
            catch (Exception ex)
            {
                int rowsAdded = 0;
                if (Session["UserName"] != null)
                {
                    rowsAdded = Model.User.AddLogMessage(Session["UserName"].ToString(), ex.Message);
                }
                else
                {
                    rowsAdded = Model.User.AddLogMessage(txtUserName.Text, ex.Message);
                }
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}