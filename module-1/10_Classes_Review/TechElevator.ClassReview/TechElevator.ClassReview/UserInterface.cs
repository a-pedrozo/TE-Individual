using System;
using System.Collections.Generic;
using System.Text;

namespace TechElevator.ClassReview
{
    public class UserInterface // always using public 
    {
        private BugManager manager = new BugManager(); // this is field or class variable 
        public UserInterface() // constructor 
        {

        }

        public void ShowMainMenu() // method
        {
            Console.WriteLine("Welcome to Moth");

            Console.WriteLine("Lets create a new bug");
            Console.WriteLine();
            Console.WriteLine("Please enter name of bug");
            string name = Console.ReadLine();

            Console.WriteLine("Who discoverd this bug?");
            string author = Console.ReadLine();

            Bug addedBug = new Bug(1, author, name);

            manager.Add(addedBug); // adds bug to manager, calling instance of object
            

            

        }
    }
}
