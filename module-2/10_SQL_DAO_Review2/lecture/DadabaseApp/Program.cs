using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Data.SqlClient;

namespace DadabaseApp
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                string connectionString = LoadConnectionString();
                // TODO: We'll need to do something with this connection string

                // Create and run the user interface
                UserInterface ui = new UserInterface(connectionString);
                ui.ShowMainMenu();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
        }

        // Static methods are still bad, 'mmmkay? 
        private static string LoadConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = config.GetConnectionString("DadJokes");

            return connectionString;
        }
    }
}
