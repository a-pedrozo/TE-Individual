using System;
using System.Collections.Generic;
using System.Text;

namespace FileInputLecture
{
    public class Part1_Exceptions
    {

        public void CauseIndexOutOfRangeException()
        {
            /* 
            * By default, when an Exception is thrown, it will "bubble up" through the call stack until
            * it reaches the main method and then will cause the program to exit and print a stacktrace
            * to the standard output 
            */

            Console.WriteLine("The following cities: ");
            string[] cities = new string[] { "Cleveland", "Columbus", "Cincinatti" };

            Console.WriteLine(cities[0]);
            Console.WriteLine(cities[1]);
            Console.WriteLine(cities[2]);
            Console.WriteLine(cities[3]);  // This statement will throw an IndexOutOfRangeException

            // The following lines won't execute because the previous statement throws an Exception
            Console.WriteLine("are all in Ohio."); 

            Console.WriteLine();
        }

        public int CauseDivisionByZeroException()
        {
            int numerator = 42;
            int divisor = 0;

            int result = numerator / divisor; // An exception will be thrown here

            // This return won't execute because the prior line throws an Exception at runtime
            return result;
        }

        private List<string> myStrings = new List<string>(); // defaults to null

        public void CauseNullReferenceException()
        {
            string aNewString = "Hello Null Reference Exceptions!";

            myStrings.Add(aNewString); // cannot call . anything on something that is currently null
        }

        public void CauseFormatException()
        {
            Console.WriteLine("Enter a number");

            string input = Console.ReadLine();

            int number = int.Parse(input); // May throw a FormatException

            Console.WriteLine("You picked " + number);
        }

        public void CallAnotherMethodThatThrowsAnException()
        {
            try
            {

            int result = CauseDivisionByZeroException();

            Console.WriteLine("The result of division was " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("divided by zero happened");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
