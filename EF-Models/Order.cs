using System;
using System.Collections.Generic;

namespace EF_Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
