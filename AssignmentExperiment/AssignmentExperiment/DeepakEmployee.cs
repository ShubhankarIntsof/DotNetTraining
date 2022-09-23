using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_First
{
    public partial class DeepakEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public DateTime? HireDate { get; set; }
        public int? Salary { get; set; }
        public int? DepartmentId { get; set; }

        public virtual DeepakDepartment Department { get; set; }
    }
}
