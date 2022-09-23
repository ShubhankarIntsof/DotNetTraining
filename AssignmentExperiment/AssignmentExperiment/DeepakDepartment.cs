using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_First
{
    public partial class DeepakDepartment
    {
        public DeepakDepartment()
        {
            DeepakEmployees = new HashSet<DeepakEmployee>();
        }

        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<DeepakEmployee> DeepakEmployees { get; set; }
    }
}
