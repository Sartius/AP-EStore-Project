using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using ES_DbUOW;
using AutoMapper;
using ES_DTO;
using ES_Mapper;
using System.Linq;

namespace ES_DAL
{
    public class UserManager : IUserManager
    {
        private IMapper _mapper;

        public UserManager(IMapper mapper)
        {
            _mapper = mapper;
        }
        public UserDtoModel UserLogin(string username, string passwordHash)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);

                User efUser = uow.Users.GetByUsernameAndPassword(username, passwordHash);
                if (efUser is null)
                {
                    return null;
                }



                UserDtoModel user = _mapper.Map<UserDtoModel>(efUser);

                return user;
            }
        }

        public UserDtoModel GetUser(int id)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);

                //EF.User efUser = uow.Users.GetAll().FirstOrDefault();

                EF_Models.User efUser = uow.Users.GetById(id);
                if (efUser is null)
                    return null;

                UserDtoModel user = _mapper.Map<UserDtoModel>(efUser);

                return user;
            }
        }

    }
}
