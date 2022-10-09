using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_First.Validation
{
    public class AddressValidator
    {

        public int AddressId { get; set; }
        [Required]
        [MaxLength(1000)]
        [Display(Name = "AddressId")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int StateProvinceId { get; set; }
        public string PostalCode { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }


    }

    [ModelMetadataType(typeof(AddressValidator))]
    public partial class Address
    {

    }
}
