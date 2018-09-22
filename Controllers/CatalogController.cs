using ShoppingCartWithAdmin.Areas.Admin.Models;
using ShoppingCartWithAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartWithAdmin.Controllers
{
    public class CatalogController : Controller
    {
        ShoppingCartContext db = new ShoppingCartContext();
        [HttpGet]
        public ActionResult Index(Product product, int catid = 0)
        {
            if (catid != 0)
            {
                var products = db.Products.Where(p => p.CatId == catid);
                return View(products.ToList());
            }
            else
            {
                return View(db.Products.ToList());
            }
        }

        public ActionResult CategoryPartialView()
        {
            ViewBag.categories = db.Categories.ToList();
            return PartialView("_Categories");
        }
        
	}
}