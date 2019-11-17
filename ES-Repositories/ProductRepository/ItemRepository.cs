using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using System.Linq;

namespace ES_Repositories.ProductRepository
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(ESDatabaseContext context)
            : base(context)
        {
        }
        public override Item GetById(object id)
        {
            //try catch for db_connection
            return _dbSet.SingleOrDefault(u => u.Id == (int)id);
        }
        public Item GetItemByCode(int code)
        {
            return _dbSet.SingleOrDefault(u => u.Code == code && u.IsActive == true);
        }
    }
}
