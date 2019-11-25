using System;
using System.Collections.Generic;

namespace EF_Models
{
    public partial class DetailedItem
    {
        public int Id { get; set; }
        public int CodeId { get; set; }
        public DateTime DatePublished { get; set; }
        public int Condition { get; set; }
        public int Gender { get; set; }
        public int Colour { get; set; }
        public string Model { get; set; }
        public int PublishedBy { get; set; }
        public string ShippingFrom { get; set; }

        public virtual ItemVersion Code { get; set; }
    }
}
