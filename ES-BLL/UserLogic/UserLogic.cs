using System;
using System.Collections.Generic;
using System.Text;
using ES_DAL;
using ES_BLL.Interfaces;

namespace ES_BLL.UserLogic
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserManager _userManager;
        public UserLogic(IUserManager userManager)
        {
            _userManager = userManager;
        }
        public bool CheckIfUserExists(string username)
        {
            return _userManager.CheckIfUsernameExists(username);
        }

        public bool UserLoginValidation(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            return true;
        }
        public bool CheckIfItemInCart(int userId,int itemCode)
        {
            return _userManager.CheckIfCartHasItem(userId, itemCode);
        }
    }
}
