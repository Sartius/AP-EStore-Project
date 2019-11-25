using System;
using System.Collections.Generic;
using System.Text;

namespace ES_BLL.Interfaces
{
    public interface IEncription
    {
        public string SaltGenerator();
        public Tuple<string, string> HashPassword(string salt, string password);
        public Tuple<string, string> DBHashProvider(string password);
        public string RecreateHash(string username, string password);
    }
}
