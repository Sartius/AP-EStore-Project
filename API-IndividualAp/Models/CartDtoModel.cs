using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_IndividualAp.Models
{
    public class CartDtoModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DateLastUpdated { get; set; }
    }
}
