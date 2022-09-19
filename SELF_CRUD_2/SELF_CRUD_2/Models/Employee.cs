using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SELF_CRUD_2.Models
{
    public class Employee
    {
        [Key]
        public int Empid { get; set; }

        [Required(ErrorMessage ="Enter Employee Name")]
        [Display(Name ="Employee Name")]
        public string Empname { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Age")]
        [Display(Name = "Age")]
        [Range(20,50)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter Salary")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }
    }
}
