using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ShoppingHelperData;

namespace ShoppingHelper.Controllers
{
    public class BaseController : Controller
    {
        public DataContext Context { get; set; }

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);

            this.Context = new ShoppingHelperData.DataContext();
        }
    }
}