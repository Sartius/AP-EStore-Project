using System;
using System.Collections.Generic;
using System.Text;
using ES_DAL;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using ES_BLL.Interfaces;

namespace ES_BLL.Encription
{
    public class Encription : IEncription
    {
        private readonly IUserManager _userManager;
        public Encription(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public string SaltGenerator()
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }


        public Tuple<string, string> DBHashProvider(string password)
        {
            return HashPassword(SaltGenerator(), password);
        }

        public string RecreateHash(string username, string password)
        {
            var pass = HashPassword(_userManager.GetPassPepper(username), password).Item1;
            if (pass != password)
                return pass;
            throw new Exception("Wrong username or password");
        }

        public Tuple<string, string> HashPassword(string salt, string password)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: Convert.FromBase64String(salt),
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8));
            Tuple<string, string> credentials = new Tuple<string, string>(hashed, salt);
            return credentials;
        }
    }
}
