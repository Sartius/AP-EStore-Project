using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF_Models;

namespace ES_Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ESDatabaseContext context)
            : base(context)
        {
        }

        public override User GetById(object id)
        {
            //try catch for db_connection
            return _dbSet.SingleOrDefault(u => u.Id == (int)id);
        }

        public User GetByUsernameAndPassword(string username, string passwordHash)
        {
            return _dbSet.SingleOrDefault(u => u.Username == username && u.Password == passwordHash);
        }
    }
}
