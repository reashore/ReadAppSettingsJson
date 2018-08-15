using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ReadAppSettingsJson
{
    internal class Program
    {
        // https://blog.bitscry.com/2017/05/30/appsettings-json-in-net-core-console-app/

        private static void Main()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            string configurationValue = configuration["parameter1"];
            //string configurationValue = configuration.GetConnectionString("connection1");

            Console.WriteLine($"configurationValue = {configurationValue}");
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
