using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string dsds = insertINTOdb("asdasd");
            CreateHostBuilder(args).Build().Run();
        }


        public static string insertINTOdb(string a)
        {
            a = "joe";
            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a += a[i] + "3";
                }

                Console.WriteLine(a);
                return a;
            }
            catch (Exception)
            {

                throw;
            }
            //insert via sql query
        }
        public void insertINTOdbViaPRocedure()
        {
            //insert via sql procedure
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
