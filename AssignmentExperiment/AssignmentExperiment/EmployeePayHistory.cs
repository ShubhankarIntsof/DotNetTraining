﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_First
{
    public partial class EmployeePayHistory
    {
        public int BusinessEntityId { get; set; }
        public DateTime RateChangeDate { get; set; }
        public decimal Rate { get; set; }
        public byte PayFrequency { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Employee1 BusinessEntity { get; set; }
    }
}
