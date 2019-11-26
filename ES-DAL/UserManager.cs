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

        public int RegisterUser(UserDtoModel userDto, DateTime cartDate)
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
        public List<Tuple<CartItemsDtoModel, ItemVersionDtoModel>> GetCartItemsWIthItems(int userId)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                List<Tuple<CartItem, ItemVersion>> cartItemWithItems =
                    uow.Carts.GetCartItemsWithItems(uow.Users.GetCartId(userId));

                List<CartItemsDtoModel> cartItemDto =
                    _mapper.Map<List<CartItemsDtoModel>>
                    (cartItemWithItems.Select(u => u.Item1).ToList());

                List<ItemVersionDtoModel> itemVersionDto =
                    _mapper.Map<List<ItemVersionDtoModel>>
                    (cartItemWithItems.Select(u => u.Item2).ToList());

                List<Tuple<CartItemsDtoModel, ItemVersionDtoModel>> cartItemWithItemsDto =
                    (from l in cartItemDto
                     join r in itemVersionDto
                     on l.ProductCode equals r.Id
                     select new Tuple<CartItemsDtoModel, ItemVersionDtoModel>(l, r)).ToList();
                return cartItemWithItemsDto;
            }
        }
        public void RemoveCartItem(int userID, int code, DateTime dateTime)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);

                CartItem cartItem = uow.Users.GetCartItem(userID, code);

                if (cartItem == null)
                    throw new ArgumentNullException("Cart item is ambiguous.");

                uow.Users.DeleteCartItem(userID, cartItem);

                uow.Carts.UpdateDate(userID, dateTime);

                uow.Commit();

            }
        }

        public string GetPassPepper(string username)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                return uow.Users.GetPassPepper(username);
            }
        }

        public CartDtoModel GetUserCart(int userId)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                Cart cart = uow.Users.GetUserCart(userId);
                CartDtoModel cartDto = _mapper.Map<CartDtoModel>(cart);
                return cartDto;
            }
        }
        public void AddItemToCart(int userId, CartItem cartItem)
        {
            using(EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                uow.Users.AddNewCartItem(userId, cartItem);
            }
        }
        public bool CheckIfCartHasItem(int userId,int itemCode)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                return uow.Users.CheckIfCartHasItem(userId, itemCode);
            }
        }

    }
}
