using System;
using System.Collections.Generic;

namespace EF_Models
{
    public partial class User
    {
        public User()
        {
            Cart = new HashSet<Cart>();
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public string Pepper { get; set; }

        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
