
namespace EE5209_3592_Assignment.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Customer()
        //{
        //    this.Items = new HashSet<Item>();
        //    this.Orders = new HashSet<Order>();
        //}

        public int CustomerId { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }
        public int Customer_Tel_No { get; set; }
        public double Total_price { get; set; }
        public string Payment_method { get; set; }

        
        //public virtual ICollection<Item> Items { get; set; }
        
        //public virtual ICollection<Order> Orders { get; set; }
    }
}
