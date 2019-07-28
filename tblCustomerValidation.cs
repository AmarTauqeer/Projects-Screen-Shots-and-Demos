using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gentry
{
    public class tblCustomerValidation
    {
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Customer name is required.")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Phone number is required.")]
        [Display(Name = "Phone No")]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Order date is required.")]
        [Display(Name = "Order Date")]
        public System.DateTime CreateDate { get; set; }
        public string ImagePath { get; set; }
    }
    [MetadataType(typeof(tblCustomerValidation))]
    public partial class Customer
    {
    }

}