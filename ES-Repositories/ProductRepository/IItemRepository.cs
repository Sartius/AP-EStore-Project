using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;

namespace ES_Repositories.ProductRepository
{
    public interface IItemRepository
    {
        public Item GetById(object id);
        public Item GetItemByCode(int code);
        public IEnumerable<Item> GetItemsByCodes(IEnumerable<int> codes);
        public List<Item> GetItemsBySearch(int category, int sortBy, string searchName);
        public void AddNewItem(Item item);
        public bool DeleteItem(int itemId);
        public bool CheckIfItemExists(int itemId);
    }
}
