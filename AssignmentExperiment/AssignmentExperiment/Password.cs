using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_First
{
    public partial class Password
    {
        public int BusinessEntityId { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Person1 BusinessEntity { get; set; }
    }
}
