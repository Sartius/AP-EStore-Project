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
    }
}
