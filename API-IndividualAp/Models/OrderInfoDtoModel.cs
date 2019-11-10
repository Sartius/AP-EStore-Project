using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_IndividualAp.Models
{
    public class OrderInfoDtoModel
    {
        public int Id { get; set; }
        public String Date { get; set; }
        public int TotalPrice { get; set; }
    }
}
