using System;
using System.Collections.Generic;

namespace EF_Models
{
    public partial class ItemVersion
    {
        public ItemVersion()
        {
            CartItem = new HashSet<CartItem>();
            DetailedItem = new HashSet<DetailedItem>();
            OrderItem = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public decimal ShippingPrice { get; set; }
        public bool Obsolete { get; set; }
        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<CartItem> CartItem { get; set; }
        public virtual ICollection<DetailedItem> DetailedItem { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
