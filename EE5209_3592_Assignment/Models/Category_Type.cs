

namespace EE5209_3592_Assignment.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Category_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Category_Type()
        //{
        //    this.Items = new HashSet<Item>();
        //}

        public int Category_TypeId { get; set; }
        public string Category_Name { get; set; }

        
        //public virtual ICollection<Item> Items { get; set; }
    }
}

