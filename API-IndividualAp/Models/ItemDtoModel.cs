using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_IndividualAp.Models
{
    public class ItemDtoModel
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgPath { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public double ShippingPrice { get; set; }
    }
}
