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
                // Create and run the user interface
                UserInterface ui = new UserInterface();
                ui.ShowMainMenu();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
        }
    }
}
