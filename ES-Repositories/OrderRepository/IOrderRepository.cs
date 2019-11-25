using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;

namespace ES_Repositories.OrderRepository
{
    public interface IOrderRepository
    {
        public Order GetById(object id);

        public List<Order> GetAllOrdersByUserId(int userId);
        public List<Tuple<OrderItem, ItemVersion>> GetAllOrderItemsWithItemsByOrderId(int orderId);
    }
}
