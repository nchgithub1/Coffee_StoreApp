//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeStore1
{
    using System;
    
    public partial class SelectOrder_details_1
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public Nullable<double> total { get; set; }
        public int payment_id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> modified_at { get; set; }
        public bool IsActive { get; set; }
        public string AddedUserName { get; set; }
        public string ModifiedUserName { get; set; }
    }
}