using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeStore1
{
    public partial class UserAccount : System.Web.UI.Page
    {

        private Boolean UserExistsYN = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    string newUserYN = "N";
                    if (Request.QueryString["NewUser"] != null)
                    {
                        newUserYN = Request.QueryString["NewUser"].ToString();
                    }

                    if (Session["UserFullName"] == null && newUserYN == "N")
                    {
                        Response.Redirect("Login.aspx", false);
                    }
                    else
                    {
                        LoadData(newUserYN);
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

        private void LoadData(string newUserYN)
        {
            try
            {
                if (newUserYN == "N")
                {
                    if (Session["UserId"] != null)
                    {
                        int userid = int.Parse(Session["UserId"].ToString());
                        List<SelectUser_1> res = Model.User.GetUser();
                        var query = from lst in res
                                    where lst.id == userid
                                    select new
                                    {
                                        useraccountname = lst.username,
                                        userpassword = Model.encrypt_decrypt.Decode(lst.password),
                                        firstname = lst.first_name,
                                        lastname = lst.last_name,
                                        address = lst.address,
                                        city = lst.city,
                                        state = lst.state,
                                        zipcode = lst.ZipCode,
                                        telephone = lst.telephone
                                    };
                        if (query != null)
                        {
                            foreach (var t in query)
                            {
                                txtUserAccountName.Text = t.useraccountname;
                                txtUserAccountPassword.Text = t.userpassword;
                                txtFirstName.Text = t.firstname;
                                txtLastName.Text = t.lastname;
                                txtAddress.Text = t.address;
                                txtCity.Text = t.city;
                                txtState.Text = t.state;
                                txtZipCode.Text = t.zipcode;
                                txtTelephone.Text = t.telephone;
                                UserExistsYN = true;
                                lblMessage.Text = "";
                            }
                        }
                        else
                        {
                            UserExistsYN = false;
                        }
                    }
                }
                else if (newUserYN == "Y")
                {
                    txtUserAccountName.Text = txtUserAccountPassword.Text = txtFirstName.Text = txtLastName.Text =
                    txtAddress.Text = txtCity.Text = txtState.Text = txtZipCode.Text = txtTelephone.Text = lblMessage.Text = "";
                    UserExistsYN = false;
                }
            }
            catch (Exception ex)
            {
                int rowsAdded = 0;
                rowsAdded = Model.User.AddLogMessage(Session["UserName"].ToString(), ex.Message);
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAdded, rowsUpdated;
                rowsAdded = rowsUpdated = 0;
                if (Session["UserId"] != null)
                {
                    rowsUpdated = Model.User.UpdateUser(int.Parse(Session["UserId"].ToString()), txtUserAccountName.Text,
                                      Model.encrypt_decrypt.Encode(txtUserAccountPassword.Text.Trim()),
                                      txtFirstName.Text.Trim(), txtLastName.Text.Trim(),
                                      txtAddress.Text.Trim(), txtCity.Text.Trim(), txtState.Text.Trim(),
                                      txtZipCode.Text.Trim(), txtTelephone.Text.Trim());
                    if (rowsUpdated > 0)
                    {
                        lblMessage.Text = txtUserAccountName.Text + " updated successfully.";
                    }
                    else
                    {
                        lblMessage.Text = txtUserAccountName.Text + " updated unsuccessfully.";
                    }
                }
                else
                {
                    rowsAdded = Model.User.AddUser(txtUserAccountName.Text,
                                     Model.encrypt_decrypt.Encode(txtUserAccountPassword.Text.Trim()),
                                     txtFirstName.Text.Trim(), txtLastName.Text.Trim(),
                                     txtAddress.Text.Trim(), txtCity.Text.Trim(), txtState.Text.Trim(),
                                     txtZipCode.Text.Trim(), txtTelephone.Text.Trim());
                    if (rowsAdded > 0)
                    {
                        lblMessage.Text = txtUserAccountName.Text + " added successfully.";
                    }
                    else
                    {
                        lblMessage.Text = txtUserAccountName.Text + " added unsuccessfully.";
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

        protected void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                string newUserYN = "N";
                if (Request.QueryString["NewUser"] != null)
                {
                    newUserYN = Request.QueryString["NewUser"].ToString();
                }

                if (Session["UserFullName"] == null && newUserYN == "N")
                {
                    Response.Redirect("Login.aspx", false);
                }
                else
                {
                    LoadData(newUserYN);
                }
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