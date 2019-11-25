using System;
using System.Collections.Generic;
using System.Text;

namespace ES_DTO
{
    public class CartItemsDtoModel
    {
        public int ProductCode { get; set; }
        public int Quantity { get; set; }
        public ItemVersionDtoModel Item { get; set; }
    }
}
