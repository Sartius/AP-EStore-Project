using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ES_Repositories;
using ES_Repositories.ProductRepository;



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
        public List<Tuple<CartItem,ItemVersion>> GetCartItemsWithItems(int cartId)
        {
            var cartItem = _dbSet.Where(u => u.Id == cartId).Single().CartItem.AsEnumerable();
            ESDatabaseContext context = new ESDatabaseContext();
            var items = context.ItemVersion.Where(u => cartItem.Select(c => c.ProductCode).Contains(u.Id)).AsEnumerable();

            return (from l in cartItem
                    join r in items
                    on l.ProductCode equals r.Id
                    select new Tuple<CartItem, ItemVersion>(l, r)).ToList();
        }
        public void UpdateDate(int userId,DateTime dateTime)
        {
            _dbSet.Where(u => u.UserId == userId).SingleOrDefault().DateLastUpdated = dateTime;
        }

    }
}
