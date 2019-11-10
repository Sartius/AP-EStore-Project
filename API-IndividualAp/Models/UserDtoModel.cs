using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_IndividualAp.Models
{
    public class UserDtoModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }   
}
