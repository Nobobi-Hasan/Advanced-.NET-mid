//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ketabkhana.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int id { get; set; }
        public int bookId { get; set; }
        public int orderId { get; set; }
        public int shopId { get; set; }
        public double unitPrice { get; set; }
        public int quantity { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Order Order { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
