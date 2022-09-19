using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DotNetCore_Web_Api.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("Data Source=192.168.1.230;Initial Catalog=Freshers_Training2022;Persist Security Info=True;User ID=trainee2022;Password=trainee@2022")
        {


        }
        public DbSet<Employee> Employees { get; set; }
    }
}