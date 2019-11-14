using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using ES_DbUOW;

namespace ES_DAL
{
    public static class UserManager
    {
        public static User UserLogin(string username, string passwordHash)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);

                EF_Models.User efUser = uow.Users.GetByUsernameAndPassword(username, passwordHash);
                if (efUser is null)
                    return null;

                User user = new User()
                {
                    Id = efUser.Id,
                    Username = efUser.Username,
                    Password = efUser.Password,
                    Role = efUser.Role
                };

                return user;
            }
        }

        public static User GetUser(int id)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);

                //EF.User efUser = uow.Users.GetAll().FirstOrDefault();

                EF_Models.User efUser = uow.Users.GetById(id);
                if (efUser is null)
                    return null;

                User user = new User()
                {
                    Id = efUser.Id,
                    Username = efUser.Username,
                    Password = efUser.Password,
                    Role = efUser.Role
                };

                return user;
            }
        }

    }
}
