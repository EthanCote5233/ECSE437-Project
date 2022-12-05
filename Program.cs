using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KannotEven
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Data.ApplicationDbContext context = new Data.ApplicationDbContext(60);

            try
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("LOGIN EXCEPTION");
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
