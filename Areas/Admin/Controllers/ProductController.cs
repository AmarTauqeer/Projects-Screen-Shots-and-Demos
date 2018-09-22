using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartWithAdmin.Areas.Admin.Models;
using ShoppingCartWithAdmin.Models;
using System.Data.Entity;
using System.IO;

namespace ShoppingCartWithAdmin.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private ShoppingCartContext db = new ShoppingCartContext();
        //
        // GET: /Admin/Product/
        public ActionResult Index()
        {
            //Product list
            List<Product> productlist = db.Products.ToList();

            ProductViewModel prdouctVM = new ProductViewModel();

            List<ProductViewModel> prodVMList = productlist.Select(x => new ProductViewModel { ProductId = x.ProductId, ProductName = x.ProductName, Price = x.Price, Description = x.Description, CatId = x.CatId, CategoryName = x.Category.CatTitle }).ToList();

            //View Model list

            return View(prodVMList);
        }

        //
        // GET: /Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            Product product = db.Products.SingleOrDefault(x => x.ProductId == id);
            ProductViewModel productVM = new ProductViewModel();

            productVM.ProductId = product.ProductId;
            productVM.ProductName = product.ProductName;
            productVM.Price = product.Price;
            productVM.Description = product.Description;
            productVM.CatId = product.CatId;
            productVM.CategoryName = product.Category.CatTitle;

            return View(productVM);
        }

        //
        // GET: /Admin/Product/Create
        public ActionResult Create()
        {
            ViewBag.CatId = new SelectList(db.Categories, "CatId", "CatTitle");
            return View();
        }

        //
        // POST: /Admin/Product/Create
        [HttpPost]
        public ActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {

                db.Products.Add(model);
                db.SaveChanges();

                model.File.SaveAs(Server.MapPath("~/Image/") + model.ProductId + ".jpg");

                
                return RedirectToAction("Index");
            }
            if (ViewBag.CatId == null)
            {
                ViewBag.CatId = new SelectList(db.Categories, "CatId", "CatTitle");
            }
            return View(model);
        }

        //
        // GET: /Admin/Product/Edit/5
        public ActionResult Edit(int id)
        {
            Product product = db.Products.Find(id);
            ViewBag.CatId = new SelectList(db.Categories, "CatId", "CatTitle", product.CatId);

            return View(product);
        }

        //
        // POST: /Admin/Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {

                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                if(product.File!=null)
                {
                    product.File.SaveAs(Server.MapPath("~/Image/") + product.ProductId + ".jpg");
                }

                return RedirectToAction("Index");
            }
            ViewBag.CatId = new SelectList(db.Categories, "CatId", "CatTitle", product.CatId);
            return View(product);
        }

        //
        // GET: /Admin/Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.Products.Where(x => x.ProductId == id).FirstOrDefault());
        }

        //
        // POST: /Admin/Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Product product = db.Products.Where(x => x.ProductId == id).FirstOrDefault();
                db.Products.Remove(product);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
