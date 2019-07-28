using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gentry
{
    public partial class tblCategoriesValidation
    {
        public int CatId { get; set; }
        [Required(ErrorMessage = "Category name is required.")]
        [DisplayName("Category")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Category description is required.")]
        [DisplayName("Description")]
        public string Description { get; set; }
    }
    [MetadataType(typeof(tblCategoriesValidation))]
    public partial class tbl_Categories
    {
    }
    
}