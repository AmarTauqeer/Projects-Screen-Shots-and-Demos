using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCartWithAdmin.Areas.Admin.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int CatId { get; set; }
        public string CategoryName { get; set; }
        public HttpPostedFileBase File { get; set; }
        public String ImageURL
        {
            get
            {
                return ProductId.ToString() + ".jpg";
            }
        }

        public virtual Category category { get; set; }
    }
}