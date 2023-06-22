using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraRichEdit.Export;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;


namespace CoffeeStore1.Model
{
    public class Payment
    {
        public static List<SelectPayment_details_1> GetPaymentDetails()
        {
            using (CoffeeEntities e = new CoffeeEntities())
            {
                return e.SelectPayment_details().ToList();
            }
        }

        public static List<SelectPayment_details_ById_1> GetPaymentDetails_ByID(int paymentID)
        {
            using (CoffeeEntities e = new CoffeeEntities())
            {
                return e.SelectPayment_details_ById(paymentID).ToList();
            }
        }

        //Adding payment details 
        // First step is to create an order_details row with payment_id = 0
        public static int AddOrderDetails(int userid, float totalamount, string username)
        {
            CoffeeEntities e = new CoffeeEntities();
            int orderID = (int)e.addOrder_details(userid, totalamount, username).FirstOrDefault();
            return orderID;
        }

        // Second step is to Insert data into the order_items for the generated order_id.
        public static int AddOrderItems(int orderid, int productid, string username)
        {
            CoffeeEntities e = new CoffeeEntities();
            int rowsAdded = (int)e.addOrder_items(orderid, productid, username).FirstOrDefault();
            return rowsAdded;
        }

        // Third step is to create a new row in the payment_details table
        public static int AddPayment(int orderid, float grandamount, string provider, string status, string nameoncard, string cardnumber,
            string expirymmyy, string securitycode, string zipcode, Boolean shipppingusercontactaddress, string shippingaddress, string username)
        {

            CoffeeEntities e = new CoffeeEntities();
            int paymentID = (int)e.addpayment_details(orderid, grandamount, provider, status, nameoncard, cardnumber, expirymmyy, securitycode, zipcode, shipppingusercontactaddress, shippingaddress, username).FirstOrDefault();
            return paymentID;
        }
        //Updating payment details 
        // First step is to update order_details row with orderid
        public static int UpdateOrderDetails(int orderid, int userid, float totalamount, int paymentId, string username)
        {
            CoffeeEntities e = new CoffeeEntities();
            int rowsUpdated = (int)e.updateOrder_details(orderid, userid, totalamount, paymentId, username).FirstOrDefault();
            return rowsUpdated;
        }
        // Second step is to update data into the order_items for the generated order_id and set old values to inActive.
        public static int UpdateOrderItems(int orderid, string username)
        {
            CoffeeEntities e = new CoffeeEntities();
            int rowsAdded = (int)e.updateOrder_items(orderid, username).FirstOrDefault();
            return rowsAdded;
        }
        // Third step is to create a new row(s) in the order_items for the generated order_id 

        // Fourth step is to update row in the payment_details table for given paymentid and orderid
        public static int UpdatePayment(int paymentid, int orderid, float amount, string provider, string status, string nameoncard, string cardnumber,
        string expirymmyy, string securitycode, string zipcode, Boolean shipppingusercontactaddress, string shippingaddress, string username)
        {
            CoffeeEntities e = new CoffeeEntities();
            int rowsUpdated = (int)e.updatePayment_details(paymentid, orderid, amount, provider, status, nameoncard, cardnumber, expirymmyy, securitycode, zipcode, shipppingusercontactaddress, shippingaddress, username).FirstOrDefault();
            return rowsUpdated;
        }
    }
}