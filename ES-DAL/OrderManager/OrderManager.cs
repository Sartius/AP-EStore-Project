using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using ES_DbUOW;
using AutoMapper;
using ES_DTO;

namespace ES_DAL.OrderManager
{

    class OrderManager : IOrderManager
    {
        private IMapper _mapper;

        public OrderManager(IMapper mapper)
        {
            _mapper = mapper;
        }


        // public void OnCheckout();
        //GetOrders
        //GetOrdersWithItems


        public bool OnCheckout(CartItem cartItem,int itemVersion)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                
                
            }
        }
    }
}
