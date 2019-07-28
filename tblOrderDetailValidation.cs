using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gentry
{
    public class tblOrderDetailValidation
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Product is required.")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Quantity is required.")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Rate is required.")]
        public int Rate { get; set; }
    }
    [MetadataType(typeof(tblOrderDetailValidation))]
    public partial class OrderDetail
    {
    }
}