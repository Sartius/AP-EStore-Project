using System;
using System.Collections.Generic;
using System.Text;

namespace ES_BLL.Interfaces
{
    public interface IUserLogic
    {
        public bool CheckIfUserExists(string username);
    }
}
