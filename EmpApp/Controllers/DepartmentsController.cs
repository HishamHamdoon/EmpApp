using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.Controllers
{
    public class DepartmentsController : Controller
    {
        public string Index()
        {
            return "this list ";
        }
        public string Index1()
        {
            return "this list 2";
        }
    }
}
