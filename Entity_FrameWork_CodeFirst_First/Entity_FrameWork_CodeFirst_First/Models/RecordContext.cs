//using Microsoft.EntityFrameworkCore;

using System.Data.Entity;

namespace Entity_FrameWork_CodeFirst_First.Models
{
    public class RecordContext : DbContext
    {
        public RecordContext() : base(@"Data Source=192.168.1.230;Initial Catalog=Freshers_Training2022;Persist Security Info=True;User ID=trainee2022;Password=trainee@2022") { 

        }
        public DbSet<Student> EF_Sh_Students { get; set; }

        //protected override void OnConfiguring()

    }
}
