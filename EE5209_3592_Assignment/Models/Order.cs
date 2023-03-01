

namespace EE5209_3592_Assignment.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Order
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public double Total_price { get; set; }
        public int Item_Id { get; set; }
        public int Customer_Id { get; set; }

        //public virtual Customer Customer { get; set; }
        //public virtual Item Item { get; set; }
    }
}

