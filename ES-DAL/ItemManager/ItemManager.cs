using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using ES_DbUOW;
using AutoMapper;
using ES_DTO;

namespace ES_DAL.ItemManager
{
    public class ItemManager : IItemManager
    {
        IMapper _mapper;
        public ItemManager(IMapper mapper)
        {
            mapper = _mapper;
        }
        public List<ItemVersionDtoModel> SearchItems(int category, int sortBy, int filter, string searchName,int page)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                List<ItemVersionDtoModel> items = new List<ItemVersionDtoModel>();
                UnitOfWork uow = new UnitOfWork(context);
                //List<ItemVersionDtoModel> items = new List<ItemDtoModel>();

                List<ItemVersion> efUsers = uow.Items.GetItemsBySearch(category, sortBy, filter, searchName);
                if (efUsers is null)
                {
                    return null;
                }
                
                    
                foreach (ItemVersion efuser in efUsers)
                {
                    items.Add(_mapper.Map<ItemVersionDtoModel>(efuser));

                }
                
                //Find How many Items are here and return only a page
                return items.GetRange(page*100,page+100);
            }
        }
        public int AddNewItem(ItemDtoModel dto_item, ItemDetailDtoModel dto_itemDetail, ItemVersionDtoModel dto_itemVersion) //dodat ItemVersionDtoModel
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                if(dto_item == null || dto_itemDetail == null || dto_itemVersion == null)
                {
                    throw new ArgumentNullException();
                }
                ItemVersion efItemVersion = _mapper.Map<ItemVersion>(dto_itemVersion);
                Item efItem = _mapper.Map<Item>(dto_item);
                DetailedItem efDetailedItem = _mapper.Map<DetailedItem>(dto_itemDetail);
                uow.Items.AddNewItem(efItemVersion);
                efItemVersion.Items.Add(efItem);
                efItemVersion.DetailedItem.Add(efDetailedItem);
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
        public bool CheckIfItemIsActive(int itemId)
        {
            using (EF_Models.ESDatabaseContext context = new EF_Models.ESDatabaseContext())
            {
                UnitOfWork uow = new UnitOfWork(context);
                return uow.Items.CheckIfItemIsActive(itemId);
            }
        }
    }
}
