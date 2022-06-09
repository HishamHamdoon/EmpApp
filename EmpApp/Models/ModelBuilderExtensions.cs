using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Hisham",
                    Email = "hisham123@gmail.com",
                    Department = Dept.IT
                },
                 new Employee
                 {
                     Id = 2,
                     Name = "Ahmed",
                     Email = "ahmed123@gmail.com",
                     Department = Dept.Hr
                 },
                  new Employee
                  {
                      Id = 3,
                      Name = "Ali Ali",
                      Email = "aliali123@gmail.com",
                      Department = Dept.Network
                  }
                );
        }
    }
}
