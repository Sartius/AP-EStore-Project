using System;
using System.Collections.Generic;

namespace EF_Models
{
    public partial class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductCode { get; set; }
        public int Quantity { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual ItemVersion ProductCodeNavigation { get; set; }
    }
}
