using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.Models
{
    public class ApplicationUser : IdentityUser
    {

        //public string RoleId { get; set; }

        //[ForeignKey("RoleId")]
        //public virtual List<IdentityRole> Roles { get; set; }
        public string City { get; set; }
    }
}
