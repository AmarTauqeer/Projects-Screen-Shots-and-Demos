using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagement.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int CustId { get; set; }

        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }

        //for order detail
        public int ProdId { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<int> ProductRate { get; set; }
        public string ProductName { get; set; }
        public int CatId { get; set; }
        public string CategoryName { get; set; }
        public decimal Amount { get; set; }
    }
}