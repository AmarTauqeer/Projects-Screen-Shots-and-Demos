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
    public class UsersController : Controller
    {
        ShoppingCartContext db = new ShoppingCartContext();
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        //
        // GET: /Admin/Users/Details/5
        public ActionResult Details(int id)
        {
            Users model = db.Users.Single(x => x.UserId == id);
            return View(model);
        }

        //
        // GET: /Admin/Users/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/Users/Create
        [HttpPost]
        public ActionResult Create(Users model)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
           
        }

        //
        // GET: /Admin/Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.Users.Where(x => x.UserId == id).FirstOrDefault());
        }

        //
        // POST: /Admin/Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Users model)
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
        // GET: /Admin/Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.Users.Where(x => x.UserId == id).FirstOrDefault());
        }

        //
        // POST: /Admin/Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Users user = db.Users.Where(x => x.UserId == id).FirstOrDefault();
                db.Users.Remove(user);
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
