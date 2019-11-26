using System;
using System.Collections.Generic;
using System.Text;
using ES_BLL.Interfaces;

namespace ES_BLL.CurrentTime
{
    class CurrentTime : ICurrentTime
    {
        public DateTime CurrentUTCTime()
        {
            return DateTime.Now.ToUniversalTime();
        }

    }
}
