using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using System.Linq;

namespace ES_Repositories.CartRepository
{
    public class CartRepository : Repository<Cart>, ICartRepository 
    {
        public CartRepository(ESDatabaseContext context)
        : base(context)
        {
        }
        public override Cart GetById(object id)
        {
            //try catch for db_connection
            return _dbSet.SingleOrDefault(u => u.Id == (int)id);
        }
    }
}
