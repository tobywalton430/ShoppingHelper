using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ShoppingHelperData.Models;

namespace ShoppingHelper.Controllers
{
    public class BasketController : BaseController
    {
        //
        // GET: /Basket/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductData()
        {            
            var products = Context.Products.ToList();            

            return Json(
                products
                    .Select(p => new { ID = p.ID, Name = p.Name })
                    .ToList()
                    .OrderBy(o => o.Name)
                , JsonRequestBehavior.AllowGet);
        }

        public ActionResult CategoryData()
        {            
            var categories = Context.Categories.ToList();

            return Json(
                categories
                    .Select(c => new { ID = c.ID, Name = c.Name })
                    .ToList()
                    .OrderBy(o => o.Name)
                , JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddProduct(int categoryID, string name)
        {            
            Context.Products.Add(
                new Product { 
                    Name = name, 
                    Description = name,
                    Category = Context.Categories.First(c => c.ID == categoryID)
                }
            );

            Context.SaveChanges();
            return null;
        }

        public ActionResult AddCategory(string name)
        {
            Context.Categories.Add(
                new Category { 
                    Name = name 
                }
            );

            Context.SaveChanges();
            return null;
        }
	}
}