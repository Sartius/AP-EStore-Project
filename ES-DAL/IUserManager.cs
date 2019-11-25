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
        public List<Tuple<CartItemsDtoModel, ItemVersionDtoModel>> GetCartItemsWIthItems(int userId);
        int RegisterUser(UserDtoModel userDto,DateTime cartdate);
        bool CheckIfUsernameExists(string username);
        string GetPassPepper(string username);
        CartDtoModel GetUserCart(int userId);
    }
}
