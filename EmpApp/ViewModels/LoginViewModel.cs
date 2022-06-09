using EmpApp.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        //[Remote(action:"IsEmailUsed",controller:"Account")]
               public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}
