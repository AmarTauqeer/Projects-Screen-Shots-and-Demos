using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gentry
{
    public partial class tblProductsValidation
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Product description is required.")]
        [DisplayName("Product Description")]
        public string ProductDescription { get; set; }
        public string Unit { get; set; }
        [DisplayName("Sale Rate")]
        public Nullable<decimal> SaleRate { get; set; }
        [DisplayName("Purchase Rate")]
        public Nullable<decimal> PurchaseRate { get; set; }
        public Nullable<int> CatId { get; set; }

        public SelectList categoryList { get; set; }
        public string ImagePath { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
    }
    [MetadataType(typeof(tblProductsValidation))]
    public partial class tbl_Products 
    {
    }
}