using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Data.SqlClient;

namespace BugTrackerConsoleApp
{
    public class Program
    {
        // Part 1: Create DDL to add a BugManager database and bugs table    (groups)
        // Part 2: Create the BugDAO class and have it implement IBugManager (together)
        // Part 3: Reference System.Data.SqlClient                           (together)
        // Part 4: Add a catch for SQL Exceptions                            (together)
        // Part 5: Write BugDAO.GetAllBugs                                   (groups)
        // Part 6: Write BugDAO.AddBug, DeleteBug, CloseBug                  (groups)

        public static void Main()
        {
            try
            {
                // Build the bug manager
                bool useFileBugManager = false;
                IBugManager bugManager;
                if (useFileBugManager)
                {
                    bugManager = BuildFileBugManager();
                } 
                else
                {
                    bugManager = BuildDatabaseBugManager(); // What we'll be building today
                }

                // Create and run the user interface, giving it whatever bug manager we chose
                UserInterface ui = new UserInterface(bugManager);
                ui.ShowMainMenu();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Static methods are still bad, 'mmmkay? 

        private static IBugManager BuildDatabaseBugManager()
        {
            string connectionString = LoadConnectionString();

            // Create and return a BugDAO
            BugDAO dao = new BugDAO(connectionString);

            return dao;
        }

        private static IBugManager BuildFileBugManager()
        {
            string csvFilePath = Path.Combine(Environment.CurrentDirectory, "bugs.csv");
            CSVFileBugManager bugManager = new CSVFileBugManager(csvFilePath);

            return bugManager;
        }

        private static string LoadConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = config.GetConnectionString("BugManager");

            return connectionString;
        }
    }
}
