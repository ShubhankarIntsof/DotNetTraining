using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_First
{
    public partial class PersonCreditCard
    {
        public int BusinessEntityId { get; set; }
        public int CreditCardId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Person1 BusinessEntity { get; set; }
        public virtual CreditCard CreditCard { get; set; }
    }
}
