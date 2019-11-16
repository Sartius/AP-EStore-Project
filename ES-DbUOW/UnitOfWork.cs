using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using ES_Repositories;

namespace ES_DbUOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ESDatabaseContext _context;
        private UserRepository _users;
        public UnitOfWork(ESDatabaseContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("Context was not supplied");
            }
            _context = context;
        }
        #region IUnitOfWork Members


        //public IRepository<User> Users
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

        public void Commit()
        {
            _context.SaveChanges();
        }
        #endregion
    }
}
