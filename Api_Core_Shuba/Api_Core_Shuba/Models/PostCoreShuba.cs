using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Api_Core_Shuba.Models
{
    public partial class PostCoreShuba
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }       
        public DateTime? CreatedDate { get; set; }

        public virtual ApiCoreShuba Category { get; set; }
    }
}
