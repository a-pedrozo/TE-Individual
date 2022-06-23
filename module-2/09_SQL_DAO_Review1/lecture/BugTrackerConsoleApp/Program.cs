using System;
using System.IO;

namespace BugTrackerConsoleApp
{
    public class Program
    {
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
            FileBasedBugManager bugManager = new FileBasedBugManager(csvFilePath);

            return bugManager;
        }

        private static IBugManager BuildDatabaseBugManager()
        {
            // TODO: Implement this!

            return null;
        }
    }
}
