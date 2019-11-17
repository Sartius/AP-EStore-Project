using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using ES_Repositories;
using ES_Repositories.CartRepository;
using ES_Repositories.OrderRepository;
using ES_Repositories.ProductRepository;

namespace ES_DbUOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ESDatabaseContext _context;
        private UserRepository _users;
        private ItemRepository _items;
        private OrderRepository _orders;
        private CartRepository _carts;
        public UnitOfWork(ESDatabaseContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("Context was not supplied");
            }
            _context = context;
        }
        #region IUnitOfWork Members


        public IUserRepository Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new UserRepository(_context);
                }
                return _users;
            }
        }
        public IItemRepository Items
        {
            get
            {
                if(_items == null)
                {
                    _items = new ItemRepository(_context);
                }
                return _items;
            }
        }
        public IOrderRepository Orders
        {
            get
            {
                if (_orders == null)
                {
                    _orders = new OrderRepository(_context);
                }
                return _orders;
            }
        }
        public ICartRepository Carts
        {
            get
            {
                if (_carts == null)
                {
                    _carts = new CartRepository(_context);
                }
                return _carts;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        #endregion
    }
}
