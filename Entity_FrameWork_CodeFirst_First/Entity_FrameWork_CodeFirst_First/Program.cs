using Entity_FrameWork_CodeFirst_First.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_FrameWork_CodeFirst_First
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            using(var ctx = new RecordContext())
            {
                var studentobj = new Student()
                {
                    Name = "Shubhankar",
                    Course = "Electrical Engineering",
                    Contact = "9999999999",
                    Email = "rohitroy@intsof.com",
                    Id = 001

                };
                ctx.EF_Sh_Students.Add(studentobj);
                ctx.SaveChanges();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
