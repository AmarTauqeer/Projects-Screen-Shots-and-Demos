using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCartWithAdmin.Areas.Admin.Models
{
    [Table("tblCart")]
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public int Price { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public String ImageURL
        {
            get
            {
                return ProductId.ToString() + ".jpg";
            }
        }
        public virtual Product product { get; set; }

    }
}