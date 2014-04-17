using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingHelperData.Models;

namespace ShoppingHelperData
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ShoppingConnection123")
        {
            this.Configuration.AutoDetectChangesEnabled = false; // BIG increase in performance when doing bulk inserts!
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
