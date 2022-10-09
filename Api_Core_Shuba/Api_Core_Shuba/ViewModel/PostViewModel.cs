using Api_Core_Shuba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Core_Shuba.ViewModel
{
    public class PostViewModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ApiCoreShuba Category { get; set; }
    }
}
