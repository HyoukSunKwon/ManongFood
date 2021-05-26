using ManongFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManongFood.Data.Services
{
    public class ManongDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
