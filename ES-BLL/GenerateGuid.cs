using System;
using System.Collections.Generic;
using System.Text;

namespace ES_BLL
{
    public class GenerateGuid
    {
        public string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
