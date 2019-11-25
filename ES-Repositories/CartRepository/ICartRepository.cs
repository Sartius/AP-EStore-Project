using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;

namespace ES_Repositories.CartRepository
{
    public interface ICartRepository
    {
        public Cart GetById(object id);
        public List<Tuple<CartItem, ItemVersion>> GetCartItemsWithItems(int cartId);
        public void UpdateDate(int userId, DateTime dateTime);
    }
}
