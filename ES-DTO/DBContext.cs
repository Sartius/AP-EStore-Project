﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ES_DTO;

namespace ES_DTO
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) :base (options)
        {

        }

        public DbSet<UserDtoModel> UserList { get; set; }
        public DbSet<ItemDtoModel> SmallItemInstance { get; set; }
        public DbSet<ItemDetailDtoModel> DetailedItemInstance { get; set; }
        public DbSet<OrderDtoModel> OrderInstance { get; set; }
        public DbSet<CartDtoModel> CartInstance { get; set; }
    }
}