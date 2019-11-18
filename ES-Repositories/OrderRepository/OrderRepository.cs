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
        public List<Order> GetAllOrdersByUserId(int userID)
        {
            return _dbSet.Where(u => u.UserId == userID).OrderBy(u => u.Date).ToList();
        }
        public IEnumerable<OrderItem> GetAllOrderItemsByOrderId(int orderId )
        {
            var order = _dbSet.Single(u => u.Id == orderId);
            //var orderitems = _dbSet(order => order.).AsEnumerable();
            return order.OrderItem;
            //return orderitems.AsEnumerable();
            //var query = _dbSet.All(u => u.OrderItem == orderItems).Join()
            //return query.ToList();
        }
        //public something list(list) GetOrdersWithItems(userid)
    }
}
