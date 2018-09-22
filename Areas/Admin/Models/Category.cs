using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCartWithAdmin.Areas.Admin.Models
{
    [Table("tblCategory")]
    public class Category
    {
        [Key]
        public int CatId { get; set; }
        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Category name is required")]
        public string CatTitle { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}