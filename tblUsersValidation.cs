using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gentry
{
    public partial class tblUsersValidation
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "User name is required.")]
        [DisplayName("User name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
    [MetadataType(typeof(tblUsersValidation))]
    public partial class tbl_Users
    {
    }
}