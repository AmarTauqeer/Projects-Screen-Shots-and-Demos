using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingCartWithAdmin.Areas.Admin.Models
{
    public class CartViewModel
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public HttpPostedFileBase File { get; set; }
        public String ImageURL
        {
            get
            {
                return ProductId.ToString() + ".jpg";
            }
        }

    }
}