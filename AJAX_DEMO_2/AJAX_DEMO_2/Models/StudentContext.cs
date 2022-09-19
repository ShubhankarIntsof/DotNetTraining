using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AJAX_DEMO_2.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base()
        {

        }
 
        public DbSet<Student> ShubaStudents {get; set;}
    }
}