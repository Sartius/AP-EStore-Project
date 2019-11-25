using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ES_DTO
{
    public class ItemDtoModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public int ItemCategory { get; set; }
        public int Quantity { get; set; }
    }
}
