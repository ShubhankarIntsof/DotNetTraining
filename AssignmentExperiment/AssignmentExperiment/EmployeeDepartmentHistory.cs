﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_First
{
    public partial class EmployeeDepartmentHistory
    {
        public int BusinessEntityId { get; set; }
        public short DepartmentId { get; set; }
        public byte ShiftId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Employee1 BusinessEntity { get; set; }
        public virtual Department Department { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
