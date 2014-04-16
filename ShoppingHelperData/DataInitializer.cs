using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShoppingHelperData.Models;

namespace ShoppingHelperData
{
    class DataInitializer : System.Data.Entity.DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var categories = new List<Category> {
                new Category { ID = 1, Name = "Fruit & Veg" },
                new Category { ID = 2, Name = "Meat & Poultry" },
                new Category { ID = 3, Name = "Bakery" }
            };

            categories.ForEach(thisCategory => context.Categories.AddOrUpdate(contextCategory => contextCategory.ID, thisCategory));
            context.SaveChanges();

            var products = new List<Product> {
                new Product { ID = 1, Name = "Apples", Description = "a", Category = context.Categories.First(c => c.Name == "Fruit & Veg") },
                new Product { ID = 2, Name = "Oranges", Description = "a", Category = context.Categories.First(c => c.Name == "Fruit & Veg") },
                new Product { ID = 3, Name = "Smoked Salmon", Description = "a", Category = context.Categories.First(c => c.Name == "Meat & Poultry") },
                new Product { ID = 4, Name = "Minced Beef", Description = "a", Category = context.Categories.First(c => c.Name == "Meat & Poultry") },
                new Product { ID = 5, Name = "Croissants", Description = "a", Category = context.Categories.First(c => c.Name == "Bakery") },
                new Product { ID = 6, Name = "Muffins", Description = "a", Category = context.Categories.First(c => c.Name == "Bakery") }
            };

            products.ForEach(thisProduct => context.Products.AddOrUpdate(contextProduct => contextProduct.ID, thisProduct));
            context.SaveChanges();
        }
    }
}
