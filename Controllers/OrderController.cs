using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderManagement.Models;
using Newtonsoft.Json;

namespace OrderManagement.Controllers
{
    public class OrderController : Controller
    {
        dbEntities db = new dbEntities();
        public ActionResult Index()
        {
            //list of customer,product and category
            List<tblProduct> ProductList = db.tblProducts.ToList();

            ViewBag.ListOfProduct = new SelectList(ProductList, "ProdId", "ProductName");

            return View();
        }
        public JsonResult GetOrderList()
        {
            //Pass The All Student Record From Controller To View For Show The All Data For User
            List<Orders> OrderList = db.OrderDetails.Select(x => new Orders
            {
                OrderId = x.OrderId,
                ProductName = x.tblProduct.ProductName,
                ProdId = x.ProdId,
                ProductRate = x.ProductRate,
                Qty=x.Qty
                
            }).ToList();

            return Json(OrderList, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetOrderById(int OrderId)
        {
            OrderDetail model = db.OrderDetails.Where(x => x.OrderId == OrderId).SingleOrDefault();
            string value = string.Empty;
            value = JsonConvert.SerializeObject(model, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value, JsonRequestBehavior.AllowGet);
        }

    }
}
