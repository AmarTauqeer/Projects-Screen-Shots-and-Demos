using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartWithAdmin.Models;
using ShoppingCartWithAdmin.Areas.Admin.Models;
using System.Web.Security;

namespace ShoppingCartWithAdmin.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        ShoppingCartContext db = new ShoppingCartContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users user)
        {
                using (ShoppingCartContext db = new ShoppingCartContext())
                {

                    var userDetail_admin = db.Users.Where(a => a.UserName.Equals(user.UserName) && a.Password.Equals(user.Password) && a.UserType.Equals("Admin")).FirstOrDefault();

                    var userDetail = db.Users.Where(a => a.UserName.Equals(user.UserName) && a.Password.Equals(user.Password)).FirstOrDefault();
                    
                    if (userDetail_admin == null && userDetail==null)
                    {
                        ViewBag.Message = "Invalid User name or Password!";
                        return View(user);
                    }
                    else
                    {

                        Session["UserID"] = userDetail.UserId.ToString();
                        Session["UserName"] = userDetail.UserName.ToString();


                        if (Session["UserID"] != null)
                        {
                            //Check for user or admin
                            if (userDetail_admin!=null)
                            {
                                return RedirectToAction("Index", "Admin");
                            }
                            else
                                return Redirect(Url.Content("~/Catalog/Index"));

                        }

                    }
                    return View(user);

                }
            }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login", "Admin");
        }

    }




}