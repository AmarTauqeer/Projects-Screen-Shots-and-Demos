using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCartWithAdmin.Areas.Admin.Models
{
    [Table("tblProduct")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product name is required.")]
        public string ProductName { get; set; }
        [Required(ErrorMessage="Price is required.")]
        public int Price { get; set; }
        public string Description { get; set; }
        public int CatId { get; set; }
        
        [NotMapped]
        public HttpPostedFileBase File { get; set; }
        
        [NotMapped]
        public String ImageURL {get{
        return ProductId.ToString()+".jpg";
        } }
        [NotMapped]
        public List<Category> CategoryList { get; set; }

        public virtual Category Category { get; set; }

    }
}