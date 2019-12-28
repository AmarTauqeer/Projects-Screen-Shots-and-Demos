using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartWithAdmin.Areas.Admin.Models;
using ShoppingCartWithAdmin.Models;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCartWithAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}