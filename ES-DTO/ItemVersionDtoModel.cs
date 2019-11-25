using System;
using System.Collections.Generic;
using System.Text;

namespace ES_DTO
{
    public class ItemVersionDtoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgPath { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public decimal ShippingPrice { get; set; }
        public bool Obsolete { get; set; }
    }
}
