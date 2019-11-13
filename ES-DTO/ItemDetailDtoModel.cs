using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ES_DTO
{
    public class ItemDetailDtoModel
    {
        public int Id { get; set; }
        public int Version { get; set; }
        public string DatePublished { get; set; }
        public string Condition { get; set; }
        public int Gender { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string PublishedBy { get; set; }
        public string ShippingFrom { get; set; }
    }
}
