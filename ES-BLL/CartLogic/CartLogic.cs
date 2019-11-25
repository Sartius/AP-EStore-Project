using System;
using System.Collections.Generic;
using System.Text;
using ES_DTO;
using ES_BLL.Interfaces;

namespace ES_BLL.CartLogic
{
    public class CartLogic : ICartLogic 
    { 
    private readonly ICurrentTime _currentTime;
    public CartLogic(ICurrentTime currentTime)
    {
        _currentTime = currentTime;
    }

    public DateTime CurrentUTCTime()
    {
        return _currentTime.CurrentUTCTime();
    }
}
}
