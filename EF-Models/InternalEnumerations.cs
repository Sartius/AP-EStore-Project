using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Models
{
    class InternalEnumerations
    {
        public enum Color
        {
            Red = 1,
            Blue = 2,
            Green = 3,
            Black = 4,
            White = 5,
            Orange = 6,
            Brown = 7
        }

        public enum Category
        {
            All = 0,
            Cars = 1,
            Shoes = 2,
            Clothes = 3,
            Electronics = 4,
            Toys = 5
        }

        public enum Condition
        {
            Fresh = 0,
            Used = 1
        }

        public enum Gender
        {
            Female = 0,
            Male = 1,
            Any = 2
        }

        public enum Role
        {
            Unlogged = 0,
            User = 1,
            Admin = 2
        }
        public enum SortBy
        {
            Date = 0,
            Price = 1,
            ShippingPrice = 2,
            Color = 3,
            Gender = 4,
            PublishedBy = 5,
            ShippingFrom = 6
    }
    }
}
