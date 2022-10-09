using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Api_Core_Shuba.Models
{
    public partial class ApiCoreShuba
    {
        public ApiCoreShuba()
        {
            PostCoreShuba = new HashSet<PostCoreShuba>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }

        public virtual ICollection<PostCoreShuba> PostCoreShuba { get; set; }
        //dont know why this priject is not working \\

        // will have to make another simple project to test 
    }
}
