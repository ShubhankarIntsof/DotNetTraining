using LINQ_ASSESMENT.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace LINQ_ASSESMENT.DbContext_
{
    public class FriendDbContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public FriendDbContext() : base()
        {
            
        }

        public .DbSet<FriendModel> Friends_Shuba { get; set; }
       
    }
}