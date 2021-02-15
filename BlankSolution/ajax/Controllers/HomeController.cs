using ajax.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ajax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Shop(int id)
        {
            var allShops = ShopsDB.Shops;
            if (id != 0 && allShops.Count>0)
            {
                return PartialView(allShops);
            }
            return HttpNotFound();
        }
    }
}