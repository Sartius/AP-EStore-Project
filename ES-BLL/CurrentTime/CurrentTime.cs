using System;
using System.Collections.Generic;
using System.Text;

namespace ES_BLL.CurrentTime
{
    class CurrentTime
    {
        public DateTime CurrentUTCTime()
        {
            return DateTime.Now.ToUniversalTime();
        }

    }
}
