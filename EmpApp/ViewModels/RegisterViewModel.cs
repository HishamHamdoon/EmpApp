using EmpApp.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.ViewModels
{
    public class RegisterViewModel
    {
       
        [Required]
        [EmailAddress]
        [ValidEmailDomain(allowedDomain: "hamdonTech.com",
        ErrorMessage = "The Email Domain must be hamdonTech.com")]
        [Remote(action: "IsEmailUsed", controller: "Account")]

        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage ="Password and confirmation password doesn't match")]
        public string ConfirmPassword { get; set; }
        public string City { get; set; }

    }
}
