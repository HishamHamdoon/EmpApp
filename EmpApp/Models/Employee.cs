using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "Name can't less than 4 digit")]
        [MaxLength(40, ErrorMessage = "Name can't greater than 40 digit")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public string PhotoPath { get; set; }
    }
}

