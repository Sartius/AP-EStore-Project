using System;
using System.Collections.Generic;
using System.Text;

namespace ES_BLL.Interfaces
{
    public interface IUserLogic
    {
        public bool CheckIfUserExists(string username);
        public bool UserLoginValidation(string username, string password);
        public bool CheckIfItemInCart(int userId, int itemCode);
    }
}
