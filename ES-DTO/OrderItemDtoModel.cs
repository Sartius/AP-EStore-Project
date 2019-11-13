using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ES_DTO
{
    public class OrderItemDtoModel
    {
        public int Id { get; set; }
        public string OrderID { get; set; }
        public ItemDtoModel Item { get; set; }
        public string Amount { get; set; }
    }
}
