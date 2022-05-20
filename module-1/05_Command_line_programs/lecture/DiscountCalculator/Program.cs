using System;

namespace DiscountCalculator
{
    /// <summary>
    /// The Program class is run when the application starts.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main method is the start and end of our program.
        /// </summary>
        /// <param name="args">Command line arguments that might get passed in to our program</param>
        public static void Main(string[] args)
        {
            /* Future Matt, please make sure we discuss the following things:
            - [ ] While Loops & Do While Loops
            - [ ] Break & Continue
            - [ ] Write vs WriteLine
            - [ ] String Formatting
            - [ ] Math Methods
            */

            Console.WriteLine("Welcome to the Discount Calculator");

            // Prompt the user for a discount amount
            // The answer needs to be saved as a double
            Console.Write("Enter the discount amount (w/out percentage): ");

            string discountString = Console.ReadLine(); // getting user info 


            Console.WriteLine("Your discount amount is " + discountString);

            int discountPercent = int.Parse(discountString); //type in discount amount

            double discount = discountPercent / 100.0;    // percentage of discount 

            double effectivePrice = 1.0 - discount;     // percent of original price 

            Console.WriteLine("The number the user typed in was " + discountPercent);

            bool keepGoing = true;
            while (keepGoing)
            {



                // Prompt the user for a series of prices
                Console.Write("Please provide a series of prices (space separated): ");

                string prices = Console.ReadLine(); // "4 8 12 23"



                // convert price string to an array of numbers
                string[] priceStrings = prices.Split(" ");

                for (int i = 0; i < priceStrings.Length; i++)
                {
                    string itemPriceString = priceStrings[i];

                    double itemPrice = double.Parse(itemPriceString);
                    double discoutedPrice = itemPrice * effectivePrice;

                    // C means format it as a currency value 
                    Console.WriteLine("The itme was priced at " + itemPrice.ToString("C")
                        + " and the sale price is  " + discoutedPrice.ToString("C"));
                }

                //ask user if they want to keep going or not
                Console.WriteLine("Do you want to keep going? Y/N");
                string keepGoingString = Console.ReadLine();

                if (keepGoingString == "N" || keepGoingString == "n")
                {
                    keepGoing = false;
                }
            }

            return;

        } // When this method finishes, the program will end.
    }
}
