using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Xunit;

namespace LINQ_ASSESMENT.Models
{
    public class FriendModel
    {
        public int FriendId { get; set; }
        [Required(ErrorMessage = "Friend Name Empty Not Allowed")]
        [StringLength(15, ErrorMessage = "Friend Name Can't exceed 15 character")]
        public string FriendName { get; set; }
        public string Place { get; set; }
    }
}