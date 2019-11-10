using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_IndividualAp.Models
{
    public class OrderDtoModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DateOfPurchase { get; set; }
        public int TotalPrice { get; set; }
        public List<OrderItemDtoModel> OrderItems { get; set; }
    }
}
