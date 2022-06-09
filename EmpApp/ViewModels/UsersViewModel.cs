using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }
        public string  Id { get; set; }
        public string City { get; set; }
        [Required][EmailAddress]
        public string UserName { get; set; }

        public string Email { get; set; }
        public IList<string> Claims { get; set; }
        public IList<string> Roles { get; set; }

    }
}
