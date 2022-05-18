using System;

namespace VariablesAndDatatypes
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello .NET!");
            Console.WriteLine();

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
            numberOfExercises = 26; // Assign 26 into the variable numberOfExervies
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
            char firstLetterOfName = 'A';
            /*
            4a. Create a variable called seasonsOfFirefly and set it to 1.
            */
            int seasonsOfFirefly = 1;
            Console.WriteLine(seasonsOfFirefly);

            /*
            4b. Create a variable called mattHasGivenUpHopeOnSeason2 and set it to false.
            */
            bool mattHasGivenUpHopeOnSeason2 = false;
                
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
            string myName = "Augustine Pedrozo";
            Console.WriteLine(myName);
            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */
            int buttonsOnMouse = 3;
            Console.WriteLine(buttonsOnMouse);
            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */
            double batteryOfPhone = 0.80;
                Console.WriteLine(batteryOfPhone);
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
            double addNum = 12.3 + 32.1;
            Console.WriteLine(addNum);
            /*
            12. Create a string that holds your full name.
            */
            string firstName = "Augustine";
            string lastName = "Pedrozo";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);
            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string hello = "Hello!" + fullName;
            Console.WriteLine(hello);
            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */
            //fullName = fullName + " Esquire";
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
            double division = 4.4 / 2.2;
            Console.WriteLine(division);
            /*
            19. What is 5.4 divided by 2?
            */
            double division2 = 5.4 / 2;
            Console.WriteLine(division2);
            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */
            double division3 = 5 / 2;
            Console.WriteLine(division3);
            /*
            21. What is 5.0 divided by 2?
            */

            double division4 = 5.0 / 2;
            Console.WriteLine(division4);


            /* Breakout */

            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */
            double bankBalance = 1234.56;
            Console.WriteLine(bankBalance);
            /*
            23. If I divide 5 by 2, what's my remainder?
            */
            int remainder = 5 % 2;
            Console.WriteLine(remainder);
            /* End Breakout */




            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together. 
                What is the result?
            */
            int var1 = 3;
            int var2 = 1000000000;
            int multiply = var1 * var2;
            Console.WriteLine(multiply);
            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */
            bool doneWithExercise = false;
            /*
            26. Now set doneWithExercise to true.
            */
            doneWithExercise = true;
            // The program will stop here and wait for the user to press enter.
            Console.ReadLine();
        }
    }
}
