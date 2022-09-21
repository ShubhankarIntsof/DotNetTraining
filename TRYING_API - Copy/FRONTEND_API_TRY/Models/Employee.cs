using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FRONTEND_API_TRY.Models
{
    public class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public string Email { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}