using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSample02.Models
{
    public static class ModelBuilderExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 1,
                        Name = "Mark",
                        Department = Dept.HR,
                        Email = "mark@pragimtech.com"
                    },
                    new Employee
                    {
                        Id = 2,
                        Name = "Smith",
                        Department = Dept.IT,
                        Email = "smith@pragimtech.com"
                    }
                );
        }
    }
}
