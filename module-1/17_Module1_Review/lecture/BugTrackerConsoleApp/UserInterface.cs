using BugTrackerConsoleApp.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugTrackerConsoleApp
{
    /// <summary>
    /// This class is responsible for all user input and menu code.
    /// </summary>
    public class UserInterface
    {
        private BugManager bugManager;

        /// <summary>
        /// Lists main menu options for the user.
        /// </summary>
        public void ShowMainMenu()
        {
            // TODO: LOAD BUGS HERE

            bool shouldQuit = false;

            while (!shouldQuit)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Moth!");
                Console.WriteLine();

                Console.WriteLine("What do you want to do?");
                Console.WriteLine();

                Console.WriteLine("1) Add a Bug");
                Console.WriteLine("2) List Existing Bugs");
                Console.WriteLine("3) Close a Bug");
                Console.WriteLine("4) Save Bugs to Disk");
                Console.WriteLine("5) Quit");
                Console.WriteLine();

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1": // Add a bug
                        AddNewItem();
                        break;

                    case "2": // List existing bugs
                        ListBugs();
                        break;

                    case "3": // Close a bug
                        CloseBug();
                        break;

                    case "4": // Save Bugs
                        SaveBugs();
                        break;

                    case "5": // Quit
                        shouldQuit = true;
                        Console.WriteLine("That's all folks!");
                        break;

                    default:
                        Console.WriteLine("I'm sorry, that's not a thing");
                        break;
                }
            }
        }

        private void ListBugs()
        {
            if (bugManager.AllBugs.Length <= 0)
            {
                Console.WriteLine("No bugs exist! Ship it!");
            }
            else
            {
                foreach (Bug someBug in bugManager.AllBugs)
                {
                    Console.WriteLine(someBug);
                }
            }
        }

        private void CloseBug()
        {
            Console.WriteLine("What is the bug ID?");
            int bugId = int.Parse(Console.ReadLine());

            Bug item = bugManager.FindBug(bugId);
            item.IsOpen = false;
        }

        private void AddNewItem()
        {
            Console.WriteLine("Please describe the bug");
            string description = Console.ReadLine();

            Console.WriteLine("Where do you suspect this bug occurs?");
            string location = Console.ReadLine();

            Bug bug = new Bug(description);
            bug.Location = location;

            bugManager.AddBug(bug);
        }

        private void SaveBugs()
        {
            throw new NotImplementedException();
        }
    }
}
