using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API_IndividualAp.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) :base (options)
        {

        }

        public DbSet<UserDtoModel> UserList { get; set; }
    }
}
