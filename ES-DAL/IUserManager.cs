using System;
using System.Collections.Generic;
using System.Text;
using ES_DTO;

namespace ES_DAL
{
    public interface IUserManager
    {
        UserDtoModel GetUser(int id);
        UserDtoModel UserLogin(string username, string passwordHash);
    }
}
