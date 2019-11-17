using System;
using System.Collections.Generic;
using System.Text;
using ES_DAL;

namespace ES_BLL.UserLogic
{
    class UserLogic : IUserLogic
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
    }
}
