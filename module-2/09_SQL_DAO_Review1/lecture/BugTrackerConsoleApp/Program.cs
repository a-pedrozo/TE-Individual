using System;
using System.IO;

namespace BugTrackerConsoleApp
{
    public class Program
    {
        // Part 1: Create DDL to add a Bug database and table
        // Part 2: Create a DAO

        public static void Main()
        {
            try
            {
                // Build the bug manager
                bool useFileBugManager = true;

                IBugManager bugManager;
                if (useFileBugManager)
                {
                    bugManager = BuildFileBugManager();
                } 
                else
                {
                    bugManager = BuildDatabaseBugManager();
                }

                // Create and run the user interface
                UserInterface ui = new UserInterface(bugManager);
                ui.ShowMainMenu();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static IBugManager BuildFileBugManager()
        {
            string csvFilePath = Path.Combine(Environment.CurrentDirectory, "bugs.csv");
            CSVFileBugManager bugManager = new CSVFileBugManager(csvFilePath);

            return bugManager;
        }

        private static IBugManager BuildDatabaseBugManager()
        {
            // TODO: Implement this!

            return null;
        }
    }
}
