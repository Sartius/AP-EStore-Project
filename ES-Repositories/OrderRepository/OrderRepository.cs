using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using System.Linq;

namespace ES_Repositories.OrderRepository
{
    public class OrderRepository : Repository<Order>, IOrderRepository 
    {
        public OrderRepository(ESDatabaseContext context)
        : base(context)
        {
        }
        public override Order GetById(object id)
        {
            //try catch for db_connection
            return _dbSet.SingleOrDefault(u => u.Id == (int)id);
        }
    }
}
