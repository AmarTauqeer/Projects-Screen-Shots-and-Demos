using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingCartWithAdmin.Areas.Admin.Models
{
    [Table("tblUser")]
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        
        [Display(Name="User Name")]
        [Required(ErrorMessage="Please enter a user name first.")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Please enter email.")]
        public string Email { get; set; }
        public int Phone { get; set; }
        [Required(ErrorMessage = "Please enter a address.")]
        public string Address { get; set; }
        [Display(Name = "User Type")]
        public string UserType { get; set; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter a password.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [NotMapped] // Does not effect with your database
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}