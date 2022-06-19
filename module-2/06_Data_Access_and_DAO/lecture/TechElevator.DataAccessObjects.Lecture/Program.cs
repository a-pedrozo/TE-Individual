using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace TechElevator.DataAccess
{
    public class Program
    {
        public static void Main()
        {
            // Ensure we have a connection string
            string connectionString = GetDatabaseConnectionString("ArtGallery");
            Console.WriteLine("Hello World! My database connection string is " + connectionString);
        }

        private static string GetDatabaseConnectionString(string settingName)
        {
            // Get the connection string from the appsettings.json file
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            return configuration.GetConnectionString(settingName);
        }
    }
}
