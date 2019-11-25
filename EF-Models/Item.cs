using System;
using System.Collections.Generic;

namespace EF_Models
{
    public partial class Item
    {
        public Item()
        {
            ItemVersion = new HashSet<ItemVersion>();
        }

        public int Id { get; set; }
        public bool IsActive { get; set; }
        public int ItemCategory { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<ItemVersion> ItemVersion { get; set; }
    }
}
