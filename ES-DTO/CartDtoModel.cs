using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace ES_DTO
{
    public class CartDtoModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string DateLastUpdated { get; set; }
    }
}
