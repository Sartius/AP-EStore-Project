using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;

namespace ES_Repositories.ProductRepository
{
    public interface IItemRepository
    {
        public ItemVersion GetById(object id);
        public bool CheckIfItemIsActive(int id);
        public IEnumerable<ItemVersion> GetItemsByCodes(IEnumerable<int> codes);
        public List<ItemVersion> GetItemsBySearch(int category, int sortBy,int filter, string searchName);
        public void AddNewItem(ItemVersion item);
        public bool DeleteItem(int itemId);
        public bool CheckIfItemExists(int itemId);
    }
}
