using System;
using System.Collections.Generic;

namespace EF_Models
{
    public partial class Item
    {
        public Item()
        {
            DetailedItem = new HashSet<DetailedItem>();
            OrderItem = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int Code { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public string ShortDescription { get; set; }
        public decimal? Price { get; set; }
        public decimal? ShippingPrice { get; set; }

        public virtual ICollection<DetailedItem> DetailedItem { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
