using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EF_Models;

namespace ES_Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ESDatabaseContext context)
            : base(context)
        {
        }

        public override User GetById(object id)
        {
            //try catch for db_connection
            return _dbSet.SingleOrDefault(u => u.Id == (int)id);
        }

        public User GetByUsernameAndPassword(string username, string passwordHash)
        {
            return _dbSet.SingleOrDefault(u => u.Username == username && u.Password == passwordHash);
        }
        public void AddNewUser(User user)
        {
            if(user == null)
            {
                throw new ArgumentNullException("Missing user info");
            }
            _dbSet.Add(user);  
        }
        public bool CheckIfUsernameExists(string username)
        {
            return _dbSet.Any(u => u.Username == username);
        }
        public IEnumerable<CartItem> GetCartItems(int userId) //Useless Prolly
        {
            return _dbSet.Where(u => u.Id == userId).SingleOrDefault().Cart.SingleOrDefault().CartItem.AsEnumerable(); 
        }
        public CartItem GetCartItem(int userId,int code) 
        {
            return _dbSet.Where(u => u.Id == userId).SingleOrDefault().Cart.SingleOrDefault().CartItem.Where(u => u.ProductCode == code).SingleOrDefault();
        }
        public int GetCartId(int userId)
        {
            return _dbSet.Where(u => u.Id == userId).SingleOrDefault().Cart.SingleOrDefault().Id;
        }

        public string GetPassPepper(string username)
        {
            return _dbSet.FirstOrDefault(u => u.Username == username).Salt;
        }

        public Cart GetUserCart(int userId)
        {
            return _dbSet.Where(u => u.Id == userId).SingleOrDefault().Cart.SingleOrDefault();
        }

        public void DeleteCartItem(int userId,CartItem cartItem)
        {
            //var sda = _dbSet.Where(u => u.Id == userId).SingleOrDefault().Cart.SingleOrDefault().CartItem.Where(u => u.ProductCode == itemCode).SingleOrDefault();
            _dbSet.Where(u => u.Id == userId).SingleOrDefault().Cart.SingleOrDefault().CartItem.Remove(cartItem);
        }

        public void AddNewCartItem(int userId, CartItem cartItem)
        {
            //var sda = _dbSet.Where(u => u.Id == userId).SingleOrDefault().Cart.SingleOrDefault().CartItem.Where(u => u.ProductCode == itemCode).SingleOrDefault();
            _dbSet.Where(u => u.Id == userId).SingleOrDefault().Cart.SingleOrDefault().CartItem.Add(cartItem);
        }
        public bool CheckIfCartHasItem(int userId,CartItem cartItem)
        {
            return _dbSet.Where(u => u.Id == userId).SingleOrDefault().Cart.Any(u => u.CartItem == cartItem);
        }
        //public bool CheckIfEmailExists( string )

        //DeleteUserById()
    }
}
