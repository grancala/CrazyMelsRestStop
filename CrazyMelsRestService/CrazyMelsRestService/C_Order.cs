//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrazyMelsRestService
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_Order
    {
        public C_Order()
        {
            this.C_Cart = new HashSet<C_Cart>();
        }
    
        public int orderID { get; set; }
        public Nullable<int> custID { get; set; }
        public string poNumber { get; set; }
        public System.DateTime orderDate { get; set; }
    
        public virtual ICollection<C_Cart> C_Cart { get; set; }
        public virtual C_Customer C_Customer { get; set; }
    }
}
