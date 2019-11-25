using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using System.Linq;
using System.Data.Entity;


namespace ES_Repositories.ProductRepository
{
    public class ItemRepository : Repository<ItemVersion>, IItemRepository 
    {
        public ItemRepository(ESDatabaseContext context)
            : base(context)
        {
        }
        public override ItemVersion GetById(object id)
        {
            //try catch for db_connection
            return _dbSet.SingleOrDefault(u => u.Id == (int)id);
        }
        public ItemVersion GetItemByIsActive(int itemId)
        {
            return _dbSet.SingleOrDefault(u => u.Item.IsActive == true && u.Id == itemId);
        }
        public IEnumerable<ItemVersion> GetItemsByCodes(IEnumerable<int> codes)
        {
            //return _dbSet.Where(u => u.Code == codes && u.IsActive == true);
            return _dbSet.Where(u => codes.Contains(u.Id));
        }
        public List<ItemVersion> GetItemsBySearch(int category, int sortBy, int filter, string searchName, int page)
        {
            List<ItemVersion> sh;
            if (category != 0) 
            {
                sh = _dbSet.Where(u => u.Item.ItemCategory == category).ToList();
            }
            if(sortBy != 0)
            {
                sh.GroupBy(u => u.DetailedItem.Single().)
            }
            return _dbSet.Where(u => u.Name.Contains(searchName) /*&& u.category == category*/).OrderBy(u => u.Price).ToList(); //figure out how to fix categories and sortby
            
        }
        public void AddNewItem(ItemVersion item)
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
                _dbSet.Where(c => c.Id == itemId).SingleOrDefault().Item.IsActive = false;
                }
            return false;
        }

        public bool CheckIfItemExists(int itemId)
        {
            return _dbSet.Any(u => u.Id == itemId);
            
        }
        public bool CheckIfItemIsActive(int itemId)
        {
            return _dbSet.Any(u => u.Id == itemId && u.Item.IsActive == true);

        }



    }
}
