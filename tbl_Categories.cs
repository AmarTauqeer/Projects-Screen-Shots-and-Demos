//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gentry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class tbl_Categories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Categories()
        {
            this.tbl_Products = new HashSet<tbl_Products>();
        }

        public int CatId { get; set; }
        [Required(ErrorMessage = "Category name is required.")]
        [DisplayName("Category")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Category description is required.")]
        [DisplayName("Description")]
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Products> tbl_Products { get; set; }
    }
}
