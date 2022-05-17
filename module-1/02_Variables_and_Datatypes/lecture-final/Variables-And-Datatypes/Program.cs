using System;

namespace VariablesAndDatatypes
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello .NET 17!");
            Console.WriteLine();

            // This is a comment., Everything to the right of // is ignored

            /* Talk about:
             * - Solution Explorer
             * - Running Programs
             * - The Console Output
             * - Compiler Errors
             * - Comments
            */

            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */

            int numberOfExercises;
            numberOfExercises = 26; // Assign 26 into the variable numberOfExercises

            Console.WriteLine(numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */

            double half = 0.5;

            Console.WriteLine(half);

            /*
            3a. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */

            string name = "TechElevator";

            Console.WriteLine(name);

            /*
            3b. Create a variable to hold the first letter of someone's name.
                Set it equal to the first letter of your name
            */

            char firstLetterOfName = 'M';

            /*
            4a. Create a variable called seasonsOfFirefly and set it to 1.
            */

            int seasonsOfFirefly = 1; // So far

            Console.WriteLine(seasonsOfFirefly);

            /*
            4b. Create a variable called mattHasGivenUpHopeOnSeason2 and set it to false.
            */

            bool mattHasGivenUpHopeOnSeason2 = true;

            Console.WriteLine(mattHasGivenUpHopeOnSeason2);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */

            string myFavoriteLanguage = "C#";

            Console.WriteLine(myFavoriteLanguage);

            /*
            6a. Create a variable called pi and set it to 3.1416.
            */

            double pi = 3.1416;

            Console.WriteLine(pi);

            /*
            6b. Create a constant for pi with the same value. Use UPPER_SNAKE_CASING.
             */

            const double PI = 3.1416;

            /* Breakout */

            /*
            7. Create and set a variable that holds your name.
            */
            string myName = "Matt Eland";

            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */

            int buttonsOnMouse = 6;

            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */

            double percentBatteryRemaining = 0.96;

            /* End Breakout */




            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */
            int difference = 121 - 27;
            Console.WriteLine(difference);

            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */
            double addition = 12.3 + 32.1;


            /*
            12. Create a string that holds your full name.
            */

            string firstName = "Matt";
            string lastName = "Eland";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);

            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */

            string hello = "Hello, " + fullName;
            Console.WriteLine(hello);

            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */

            fullName = fullName + " Esquire";
            //Console.WriteLine(fullName);

            /*
            15. Now do the same as exercise 14, but use the += operator.
            */

            fullName += " Esquire";
            Console.WriteLine(fullName);

            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */

            string saw = "Saw" + 2;
            Console.WriteLine(saw);

            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */

            saw += 0;
            Console.WriteLine(saw);

            /*
            18. What is 4.4 divided by 2.2?
            */

            double division = 4.4 / 2.2; // 2.0

            /*
            19. What is 5.4 divided by 2?
            */

            double division2 = 5.4 / 2; // 2.7

            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */

            double division3 = 5 / 2; // 2 due to integer division - remainders are ignored

            Console.WriteLine(division3);

            int remainder = 5 % 2;
            Console.WriteLine(remainder);

            /* 
            21. What is 5.0 divided by 2?
            */

            double division4 = 5.0 / 2;
            Console.WriteLine(division4);



            /* Breakout */

            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */
            double balance1 = 1234.56;
            decimal balance2 = 1234.56m;

            /*
            23. If I divide 5 by 2, what's my remainder?
            */

            int remainder2 = 5 % 2; // 1

            /* End Breakout */




            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together. 
                What is the result?
            */
            int three = 3;
            int oneBillion = 1000000000;
            int largeNumber = oneBillion * three;

            Console.WriteLine(largeNumber);

            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */

            bool doneWithExercises = false;

            /*
            26. Now set doneWithExercise to true.
            */
            doneWithExercises = !doneWithExercises;
            doneWithExercises = true;

            // The program will stop here and wait for the user to press enter.
            Console.ReadLine();
        }
    }
}
