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
        public List<Tuple<CartItem, Item>> GetAllCartItemsWithItemsByCartId(int cartId)
        {
            var cartItem = _dbSet.Include(x => x.CartItem).Where(u => u.Id == cartId).SingleOrDefault().CartItem;
            var itemcodes = cartItem.Select(x => x.ProductCode);
            var bb = 
            List<Tuple<CartItem, Item>> innerFinal = (from l in cartItem
                                                       join r in _dbSet.Where()
                                                       on l.ProductId equals r.Code
                                                       select new Tuple<OrderItem, Item>(l, r)).ToList();

            return innerFinal;
        }
    }
}
