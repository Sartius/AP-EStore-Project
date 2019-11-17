using System;
using System.Collections.Generic;
using System.Text;

namespace ES_BLL.UserLogic
{
    interface IUserLogic
    {
        public bool CheckIfUserExists(string username);
    }
}
