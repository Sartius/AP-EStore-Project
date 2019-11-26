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


        public bool OnCheckout(int userId,CartDtoModel cartDto,List<CartItemsDtoModel> cartItemDto)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                var cart = _mapper.Map<Cart>(cartDto);
                var cartItems = _mapper.Map<List<CartItem>>(cartItemDto);
                
            }
        }
    }
}
