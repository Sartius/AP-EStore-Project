using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;

namespace ES_Repositories
{
    public interface IUserRepository
    {
        User GetById(object id);
        User GetByUsernameAndPassword(string username, string passwordHash);
        void AddNewUser(User user);
        bool CheckIfUsernameExists(string username);
        public IEnumerable<CartItem> GetCartItems(int userId);
        public int GetCartId(int userId);
    }
}
