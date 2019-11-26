using System;
using System.Collections.Generic;
using System.Text;
using ES_BLL.Interfaces;

namespace ES_BLL.ItemLogic
{
    public class ItemLogic : IItemLogic
    {
        private readonly ICurrentTime _currentTime;
        public ItemLogic(ICurrentTime currentTime)
        {
            _currentTime = currentTime;
        }
        public DateTime CurrentUTCTime()
        {
            return _currentTime.CurrentUTCTime();
        }
        public string GenerateGUID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
