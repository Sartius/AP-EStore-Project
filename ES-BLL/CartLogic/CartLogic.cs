using System;
using System.Collections.Generic;
using System.Text;
using ES_DTO;

namespace ES_BLL.CartLogic
{
    public class CartLogic : ICartLogic
    {
        public DateTime SetDateTime()
        {
            return DateTime.Now;
        }
    }
}
