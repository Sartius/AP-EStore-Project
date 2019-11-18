using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using ES_DbUOW;
using AutoMapper;
using ES_DTO;

namespace ES_DAL.ItemManager
{
    class ItemManager : IItemManager
    {
        IMapper _mapper;
        public ItemManager(IMapper mapper)
        {
            mapper = _mapper;
        }
        public List<ItemDtoModel> SearchItems(int category, int sortBy, string searchName)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                List<ItemDtoModel> items = new List<ItemDtoModel>();

                List<EF_Models.Item> efUsers = uow.Items.GetItemsBySearch(category, sortBy, searchName);
                if (efUsers is null)
                {
                    return null;
                }
                    
                foreach (Item efuser in efUsers)
                {
                    items.Add(_mapper.Map<ItemDtoModel>(efuser));

                }
                

                return items;
            }
        }
        public int AddNewItem(ItemDtoModel item, ItemDetailDtoModel itemDetail)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                if(item == null || itemDetail == null)
                {
                    throw new ArgumentNullException();
                }
                Item efItem = _mapper.Map<Item>(item);
                DetailedItem efDetailedItem = _mapper.Map<DetailedItem>(itemDetail);
                uow.Items.AddNewItem(efItem);
                efItem.DetailedItem.Add(efDetailedItem);
                uow.Commit();

                int itemID = efItem.Id;
                return itemID;
            }
        }
        public void DeleteItem(int itemId)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                uow.Items.DeleteItem(itemId);
            }
        }
    }
}
