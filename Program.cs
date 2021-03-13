//    Change History 
// Date - Developer - Changes
// 3/12/2021 - Steven Nguyen - Created the project
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using Microsoft.Extensions.DependencyInjection;



namespace ContosoUniversity
{
    public class Program
    {
        public static void Main(string[] args)
        {
          //tinfo200:[2021 - 03 - 12 -< Steven28 > -dykstra]
          //We kind of keep the old code but instead of having the bulider start running we do a file check
            var host = CreateHostBuilder(args).Build();

            //The method just checks if we have the initializer for us to use and display our database if
            //not then an error will occurs
            CreateDbIfNotExists(host);



            //After we check if the initializer does or does not exsist 
            host.Run();
        }

        //Kind of explained already above
        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {

                //a Try and catch for checking if the iniitlzer is present for us to use on excpetion we then
                //put out in the log an error has occured 
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<SchoolContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
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
