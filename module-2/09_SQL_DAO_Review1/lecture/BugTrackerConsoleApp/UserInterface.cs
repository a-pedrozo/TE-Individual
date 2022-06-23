using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BugTrackerConsoleApp
{
    /// <summary>
    /// This class is responsible for all user input and menu code.
    /// </summary>
    public class UserInterface
    {
        private IBugManager bugManager;

        public UserInterface(IBugManager bugManager)
        {
            this.bugManager = bugManager;
        }

        /// <summary>
        /// Lists main menu options for the user.
        /// </summary>
        public void ShowMainMenu()
        {
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

                string text = "ABC";
                string text2 = text.PadRight(5);

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

                    case "4": // Delete Bugs
                        DeleteBug();
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
            List<Bug> bugs = bugManager.GetAllBugs();

            if (bugs.Count <= 0)
            {
                Console.WriteLine("No bugs exist! Ship it!");
            }
            else
            {
                foreach (Bug someBug in bugs)
                {
                    Console.WriteLine(someBug);
                }
            }
        }

        private void CloseBug()
        {
            Console.WriteLine("What is the bug ID?");
            int bugId = int.Parse(Console.ReadLine());

            if (bugManager.CloseBug(bugId))
            {
                Console.WriteLine("Bug Closed!");
            }
            else
            {
                Console.WriteLine("Could not close the bug with ID of " + bugId);
            }
        }

        private void DeleteBug()
        {
            Console.WriteLine("What is the bug ID?");
            int bugId = int.Parse(Console.ReadLine());

            if (bugManager.DeleteBug(bugId))
            {
                Console.WriteLine("Bug Deleted!");
            }
            else
            {
                Console.WriteLine("Could not delete the bug with ID of " + bugId);
            }
        }

        private void AddNewItem()
        {
            Console.WriteLine("Please describe the bug");
            string description = Console.ReadLine();

            Bug bug = new Bug(description);

            bugManager.AddBug(bug);
        }
    }
}
