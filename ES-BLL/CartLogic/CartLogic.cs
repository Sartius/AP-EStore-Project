using System;
using System.Collections.Generic;
using System.Text;
using ES_DTO;
using ES_DAL.ItemManager;
using ES_BLL.Interfaces;

namespace ES_BLL.CartLogic
{
    public class CartLogic : ICartLogic 
    { 
    private readonly ICurrentTime _currentTime;
    //private readonly IUserManager _userManager;
        private readonly IItemManager _itemManager;
    public CartLogic(ICurrentTime currentTime, IItemManager itemManager)
    {
        _currentTime = currentTime;
        //_userManager = userManager;
        _itemManager = itemManager;
    }

    public DateTime CurrentUTCTime()
    {
        return _currentTime.CurrentUTCTime();
    }

    public bool OnCheckout(int userId, CartDtoModel cartDtoModel, List<CartItemsDtoModel> cartItemsDtoModels)
        {
            if(cartItemsDtoModels == null ||cartDtoModel == null)
            {
                throw new ArgumentNullException("The Cart Is Empty?");
            }
            //if(_userManager) check userId
            //Check if all items in cart are Active
            foreach(CartItemsDtoModel item in cartItemsDtoModels)
            {
                if(_itemManager.CheckIfItemIsActive(item.ProductCode) == false)
                {
                    return false; //Don't let the user buy an inactive Item or let him but check quantity. Throw a custom exception myb?
                }
            }

        }
}
}
