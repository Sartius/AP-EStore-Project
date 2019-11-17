using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;

namespace ES_Repositories.CartRepository
{
    public interface ICartRepository
    {
        public Cart GetById(object id);
    }
}
