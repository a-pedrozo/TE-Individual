using System;
using System.Collections.Generic;
using System.Text;

namespace TechElevator.ClassReview
{
    public class UserInterface
    {
        // Field or Class Variable
        private BugManager manager = new BugManager();

        // Constructor
        public UserInterface()
        {

        }

        // Method
        public void ShowMainMenu()
        {
            Console.WriteLine("Welcome to Moth");

            Console.WriteLine("Time to create a new bug!");
            Console.WriteLine();
            Console.WriteLine("Please enter the name of the bug");
            string name = Console.ReadLine();

            Console.WriteLine("Who discovered this bug?");
            string author = Console.ReadLine();

            Bug addedBug = new Bug(1, author, name);

            manager.Add(addedBug);
        }
    }
}
