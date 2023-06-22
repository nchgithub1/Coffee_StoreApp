using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeStore1.Model
{
    public class Product
    {
        public static int AddCartItem(int sessionid, int productid, int quantity, string addedUser)
        {
            CoffeeEntities e = new CoffeeEntities();
            int rowsAdded = (int)e.addCartItem(sessionid, productid, quantity, addedUser, DateTime.Now, true).FirstOrDefault();
            return rowsAdded;
        }

        public static int DeleteCartItem(int cartitemid, string username)
        {
            CoffeeEntities e = new CoffeeEntities();
            int rowsDeleted = (int)e.deleteCartItem(cartitemid, username).FirstOrDefault();
            return rowsDeleted;
        }

        public static int UpdateCartItem(int cartitemid, int quantity, string username)
        {
            CoffeeEntities e = new CoffeeEntities();
            int rowsUpdated = (int)e.updateCartItem(cartitemid, quantity, username).FirstOrDefault();
            return rowsUpdated;
        }

        public static List<SelectCartItem_BySessionID_1> GetCartItembySessionID(int sessionID)
        {
            using (CoffeeEntities e = new CoffeeEntities())
            {
                return e.SelectCartItem_BySessionID(sessionID).ToList();
            }
        }

        public static List<SelectCartItemGrandTotal_BySessionID_1> GetCartItemGrandTotal_BySessionID(int sessionID)
        {
            using (CoffeeEntities e = new CoffeeEntities())
            {
                return e.SelectCartItemGrandTotal_BySessionID(sessionID).ToList();
            }
        }
    }
}