using ShoppingCartWithAdmin.Areas.Admin.Models;
using ShoppingCartWithAdmin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartWithAdmin.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private ShoppingCartContext db = new ShoppingCartContext();
        //
        // GET: /Admin/Category/
        public ActionResult Index()
        {
            using (ShoppingCartContext db = new ShoppingCartContext())
            {
                return View(db.Categories.ToList());
            }
        }

        //
        // GET: /Admin/Category/Details/5
        public ActionResult Details(int id)
        {
            Category cat = db.Categories.Single(x => x.CatId == id);
            return View(cat);
        }

        //
        // GET: /Admin/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/Category/Create
        [HttpPost]
        public ActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        //
        // GET: /Admin/Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.Categories.Where(x => x.CatId == id).FirstOrDefault());
        }

        //
        // POST: /Admin/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {

                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //
        // GET: /Admin/Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.Categories.Where(x => x.CatId == id).FirstOrDefault());
        }

        //
        // POST: /Admin/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Category cat = db.Categories.Where(x => x.CatId == id).FirstOrDefault();
                db.Categories.Remove(cat);
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
