using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Display(Name="User name")]
        [Required(ErrorMessage="Enter user name.")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Enter password field.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Enter confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Enter full name.")]
        public string FullName { get; set; }
        
        [Required(ErrorMessage = "Enter city name.")]
        public string City { get; set; }
        
        [Required(ErrorMessage = "Enter address.")]
        public string Address { get; set; }
        
        [Required(ErrorMessage = "Enter email.")]
        public string Email { get; set; }

    }
}