﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoffeeStore1
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //if (!IsPostBack)
                //{
                //    if (Session["UserFullName"] == null)
                //    {
                //        Response.Redirect("Login.aspx", false);
                //    }
                //}
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