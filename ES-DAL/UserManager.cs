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
                    throw new Exception("Wrong username or password");
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

        public int RegisterUser(UserDtoModel userDto,DateTime cartDate)
        {
            if (userDto == null)
            {
                throw new ArgumentNullException("User info not supplied");
            }

            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                User efUser = _mapper.Map<User>(userDto);
                uow.Users.AddNewUser(efUser);

                DateTime SetDateTime()
                {
                    return DateTime.Now;
                }

                Cart efCart = new Cart()
                {
                    DateLastUpdated = cartDate
                };
                efUser.Cart.Add(efCart);
                uow.Commit();
                int userID = efUser.Id;
                return userID;
            }
        }
        public bool CheckIfUsernameExists(string username)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                return uow.Users.CheckIfUsernameExists(username);
            }
        }

    }
}
