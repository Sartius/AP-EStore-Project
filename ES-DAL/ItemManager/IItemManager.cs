using System;
using System.Collections.Generic;
using System.Text;
using ES_DTO;

namespace ES_DAL.ItemManager
{
    public interface IItemManager
    {
        
        public int AddNewItem(ItemDtoModel dto_item, ItemDetailDtoModel dto_itemDetail, ItemVersionDtoModel dto_itemVersion);
        public bool CheckIfItemIsActive(int itemId);
        public List<ItemVersionDtoModel> SearchItems(int category, int sortBy, int filter, string searchName, int page);
    }
}
