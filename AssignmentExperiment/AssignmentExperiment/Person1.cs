using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_First
{
    public partial class Person1
    {
        public Person1()
        {
            BusinessEntityContacts = new HashSet<BusinessEntityContact>();
            Customers = new HashSet<Customer>();
            EmailAddresses = new HashSet<EmailAddress>();
            PersonCreditCards = new HashSet<PersonCreditCard>();
            PersonPhones = new HashSet<PersonPhone>();
        }

        public int BusinessEntityId { get; set; }
        public string PersonType { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public string AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual Employee1 Employee1 { get; set; }
        public virtual Password Password { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
    }
}
