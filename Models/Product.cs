using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.WebPages.Html;
using System.Configuration;
using System.Data.SqlClient;
namespace OrderManagement.Models
{
    public class Product
    {
        public int ProdId { get; set; }
        public int CatId { get; set; }

        [Required(ErrorMessage="Please enter product name")]
        [Display(Name="Product name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please enter product rate")]
        [Display(Name = "Product rate")]
        public int ProductRate { get; set; }
        public string Units { get; set; }

    }
}