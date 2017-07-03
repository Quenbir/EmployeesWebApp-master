using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace EmployeesWebApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string Motto { get; set; }
        public string Hobby { get; set; }
        public string Hometown { get; set; }
        public string Blog { get; set; }
        

    }
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

    }
}