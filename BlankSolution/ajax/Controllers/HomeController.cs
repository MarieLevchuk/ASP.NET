using ajax.Database;
using ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ajax.Controllers
{
    public class HomeController : Controller
    {
        List<Shop> shops;
        public HomeController()
        {
            shops = ShopsDB.Shops;
        }

        public ActionResult Index()
        {
            shops = ShopsDB.Shops;
            Tuple<List<Shop>, Shop> tuple = new Tuple<List<Shop>, Shop>(shops, shops[0]);            
            return View("ShopsData", tuple);
        }
        
        [HttpPost]
        public PartialViewResult ShopsData(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                Shop selshop = shops.Where(x => x.Id.ToString() == id).FirstOrDefault();
                return PartialView("_shopDescription", selshop);
            }
            return PartialView("ShopsData");
        }
    }
}