using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingHelper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new ShoppingHelperData.DataContext();
            var products = context.Products.ToList();            

            //return View();
            return RedirectToAction("Index", "Basket");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}