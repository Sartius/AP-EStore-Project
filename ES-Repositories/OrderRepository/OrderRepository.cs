using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        public List<Order> GetAllOrdersByUserId(int userID)
        {
            return _dbSet.Where(u => u.UserId == userID).OrderBy(u => u.Date).ToList();
        }
        public List<Tuple<OrderItem,ItemVersion>> GetAllOrderItemsWithItemsByOrderId(int orderId )
        {
            var order = _dbSet.Include(x => x.OrderItem).Where(u => u.Id == orderId).SingleOrDefault().OrderItem;
            var orderItem = order.Select(x => x.Product);
            List<Tuple<OrderItem,ItemVersion>> innerFinal = (from l in order
                              join r in order.Select(x => x.Product)
                              on l.ProductId equals r.Id
                              select new Tuple<OrderItem, ItemVersion>(l,r)).ToList();
            
            return innerFinal;
        }

        public bool AddOrder()
        {

        }
        //public something list(list) GetOrdersWithItems(userid)
    }
}
