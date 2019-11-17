using System;
using System.Collections.Generic;
using System.Text;
using ES_DTO;

namespace ES_DAL.ItemManager
{
    public interface IItemManager
    {
        public List<ItemDtoModel> SearchItems(int category, int sortBy, string searchName);
        public int AddNewItem(ItemDtoModel item, ItemDetailDtoModel itemDetail);
    }
}
