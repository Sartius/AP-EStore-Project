﻿using System;
using System.Collections.Generic;

namespace EF_Models
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual ItemVersion Product { get; set; }
    }
}
