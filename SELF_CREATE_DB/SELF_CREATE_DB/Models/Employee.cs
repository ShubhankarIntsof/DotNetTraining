using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SELF_CREATE_DB.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Department { get; set; }
    }
}