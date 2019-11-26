using System;
using EF_Models;
using ES_DTO;
using AutoMapper;

namespace ES_Mapper
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<User, UserDtoModel>().ReverseMap();

            //CreateMap<UserDtoModel, User>().ReverseMap();

            CreateMap<Cart, CartDtoModel>().ReverseMap();
            CreateMap<Cart, Order>().ReverseMap();
            CreateMap<CartItem, OrderItem>().ReverseMap();

            CreateMap<Order, OrderDtoModel>().ReverseMap();

            CreateMap<CartItem, OrderItemDtoModel>().ReverseMap();

            CreateMap<OrderItem, OrderItemDtoModel>().ReverseMap();

            CreateMap<Item, ItemDtoModel>().ReverseMap();

            CreateMap<ItemVersion, ItemVersionDtoModel>().ReverseMap();

            CreateMap<DetailedItem, ItemDetailDtoModel>().ReverseMap();
        }
    }
}
