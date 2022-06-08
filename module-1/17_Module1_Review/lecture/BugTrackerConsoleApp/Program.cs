using System;

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
            catch (Exception ex)
            {
                Console.WriteLine("A bad thing happened. The program is now closing. Sorry.");
            }
        }
    }
}
