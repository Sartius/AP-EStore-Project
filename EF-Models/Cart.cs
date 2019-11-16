using System;
using System.Collections.Generic;

namespace EF_Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartItem = new HashSet<CartItem>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime? DateLastUpdated { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<CartItem> CartItem { get; set; }
    }
}
