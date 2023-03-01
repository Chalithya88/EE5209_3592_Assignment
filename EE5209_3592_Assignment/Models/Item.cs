

namespace EE5209_3592_Assignment.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Item()
        //{
        //    this.Orders = new HashSet<Order>();
        //}

        public int ItemId { get; set; }
        public string Item_Name { get; set; }
        public double Item_Price { get; set; }
        public int Customer_Id { get; set; }
        public int Category_Id { get; set; }

        //public virtual Category_Type Category_Type { get; set; }
       // public virtual Customer Customer { get; set; }
       
        //public virtual ICollection<Order> Orders { get; set; }
    }
}

