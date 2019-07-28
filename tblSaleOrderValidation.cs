using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gentry
{
    public class tblSaleOrderValidation
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Order date is required.")]
        [Display(Name = "Order Date")]
        public System.DateTime OrderDate { get; set; }
        [Display(Name = "Order Status")]
        public string OrderStatus { get; set; }
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
    }
    [MetadataType(typeof(tblSaleOrderValidation))]
    public partial class OrderMaster
    {
    }


}