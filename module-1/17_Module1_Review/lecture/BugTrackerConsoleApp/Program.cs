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
                UserInterface ui = new UserInterface();
                ui.ShowMainMenu();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
