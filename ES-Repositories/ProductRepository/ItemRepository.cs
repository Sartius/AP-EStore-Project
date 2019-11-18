using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using System.Linq;

namespace ES_Repositories.ProductRepository
{
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(ESDatabaseContext context)
            : base(context)
        {
        }
        public override Item GetById(object id)
        {
            //try catch for db_connection
            return _dbSet.SingleOrDefault(u => u.Id == (int)id);
        }
        public Item GetItemByCode(int code)
        {
            return _dbSet.SingleOrDefault(u => u.Code == code && u.IsActive == true);
        }
        public List<Item> GetItemsBySearch(int category, int sortBy,string searchName)
        {
            return _dbSet.Where(u => u.Name.Contains(searchName)).OrderBy(u => u.Price).ToList(); //figure out how to fix categories and sortby
        }
        public void AddNewItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Missing item info");
            }
            _dbSet.Add(item);
            
        }
        public bool DeleteItem(int itemId)
        { 
            if(!CheckIfItemExists(itemId)) 
                {
                _dbSet.Where(c => c.Id == itemId && c.IsActive).ToList().Select(c => c.IsActive = false);
                }
            return false;
        }

        public bool CheckIfItemExists(int itemId)
        {
            return _dbSet.Any(u => u.Id == itemId);
        }

        public IEnumerable<Item> GetOrderItems(IEnumerable<int> idList)
        {
               
        }

    }
}
