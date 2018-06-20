using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.WebPages.Html;


namespace OrderManagement.Models
{
    public class CategoryModel
    {
        public int CatId { get; set; }
        [StringLength(100)]
        public string Category { get; set; }

    }
}