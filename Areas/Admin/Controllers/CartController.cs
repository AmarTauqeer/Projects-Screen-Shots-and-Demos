using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartWithAdmin.Areas.Admin.Models;
using ShoppingCartWithAdmin.Models;
using System.Data.Entity;

namespace ShoppingCartWithAdmin.Areas.Admin.Controllers
{
    public class CartController : Controller
    {
        ShoppingCartContext db = new ShoppingCartContext();
        public ActionResult Index()
        {
            //Cart Product list
            List<Cart> CartProdlist = db.Carts.ToList();

            CartViewModel CartVM = new CartViewModel();

            List<CartViewModel> CartVMList = CartProdlist.Select(x => new CartViewModel { CartId = x.CartId, ProductId = x.ProductId,ProductName=x.product.ProductName, Qty = x.Qty, Price = x.Price, CreatedDateTime = x.CreatedDateTime }).ToList();

            return View(CartVMList);
        }
        [HttpPost]
        public ActionResult Index( CartViewModel p)
        {
            if (ModelState.IsValid)
            {
                if (Session["Cart"] != null)
                {
                    var ls = Session["Cart"] as List<CartViewModel>;
                    ls.Add(p);
                }
                else
                {
                    Session["Cart"] = new List<CartViewModel>() { p };
                }
                ModelState.Clear();
                RedirectToAction("Index", "Cart");

            }
            return View();
        }
        public ActionResult Create(int prodid, int price)
        {
            int cartid = 0;
            double totalQty = 0;
            //check partameters
            if (prodid>0 && price>0)
            {
                //check if item already exist

                var result = db.Carts.Count();
                if (result == 0)
                {
                    //insert into db
                    var cartModel = new Cart();

                    cartModel.ProductId = prodid;
                    cartModel.Qty = 1;
                    cartModel.Price = price;
                    cartModel.CreatedDateTime = System.DateTime.Now;
                    //totalQty = cartModel.Qty;
                    db.Carts.Add(cartModel);
                }
                else 
                {
                    var model = db.Carts.Where(p => p.ProductId == prodid).Select(p => new { p.CartId});
                    
                    foreach (var item in model)
                    {
                        cartid = item.CartId;
                        //TempData["msg"] = item.CartId;
                        
                    }
                    
                    //var cartModel = db.Carts.Where(x => x.ProductId == prodid).Select(x => new Cart() { CartId = x.CartId });
                    
                    var cartModel = db.Carts.Where(x => x.ProductId == prodid && x.CartId==cartid).SingleOrDefault();
                    if (cartModel != null)
                    {
                        cartModel.Qty += 1;
                        db.Entry(cartModel).State = EntityState.Modified;
                        //totalQty += cartModel.Qty;
                    }
                    else 
                    {
                        //insert into db
                        var cart = new Cart();

                        cart.ProductId = prodid;
                        cart.Qty = 1;
                        cart.Price = price;
                        cart.CreatedDateTime = System.DateTime.Now;
                        //totalQty += cart.Qty;
                        db.Carts.Add(cart);

                    }
                }
                db.SaveChanges();
                //TempData["totalQty"] = totalQty;
                return RedirectToAction("Index", "Catalog", new { area = string.Empty });
            }
            return null;
        }
        public ActionResult Delete(int id)
        {
            return View(db.Carts.Where(x => x.CartId == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Cart cart = db.Carts.Where(x => x.CartId == id).FirstOrDefault();
                db.Carts.Remove(cart);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult Checkout()
        {
            if (Session["Cart"] == null)
            {
                RedirectToAction("Index", "Cart");

            }
            //Cart Product list
            List<Cart> CartProdlist = db.Carts.ToList();

            CartViewModel CartVM = new CartViewModel();

            List<CartViewModel> CartVMList = CartProdlist.Select(x => new CartViewModel { CartId = x.CartId, ProductId = x.ProductId, ProductName = x.product.ProductName, Qty = x.Qty, Price = x.Price, CreatedDateTime = x.CreatedDateTime }).ToList();

            return View(CartVMList);

            var ls = Session["Cart"] as List<CartViewModel>;
            return View(ls);
            
        }

        public ActionResult GetDataPaypal()
        {
            return View();
        }
	}
}