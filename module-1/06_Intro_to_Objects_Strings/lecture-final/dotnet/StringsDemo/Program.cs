using System;

namespace StringsDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* ----- PART 0: Classes and Objects --------- */

            // Classes are TEMPLATES used to create individual INSTANCES of objects.
            // We sometimes call this "instantiating an object"

            // Create a new instance of the HondaCivic class and assign it into a variable
            HondaCivic mattsCar = new HondaCivic();
            mattsCar.OdometerMiles = 12345;

            // Create another instance of the HondaCivic class and assign it into a different variable
            HondaCivic johnsCar = new HondaCivic();
            johnsCar.OdometerMiles = 10;



            // What is Matt's car? What is John's car?



            mattsCar.HonkHorn();
            johnsCar.HonkHorn();



            /* ----- PART 1-A: Reference Types ---------- */

            // This is a silly class that you wouldn't create in the real world, but it helps us with lecture
            StackHeapExamples helper = new StackHeapExamples();

            int milesToDrive = 22;
            helper.Drive(mattsCar, milesToDrive);

            // How many miles are on Matt's odometer? What about John's?



            /* ----- PART 1-B: Value Types -------------- */


            int year = 2022;
            helper.IncreaseNumber(year);

            // What is the value of year?


            // What are value types?

            // What are reference types?



            /* ------ E-Mailed Document Metaphor -------- */



            /* ------ PART 1-C: Reference Types again --- */

            // What if Matt let Dan use his car?

            // What if Matt got a new car?

            // What if Matt and his wife shared the same car?




            /* ----- PART 2: Immutability --------------- */

            // Demonstrate immutability
            string message = "HELLO THERE! Nice to see you in this QUIET LIBRARY!";

            message = message.ToLower();

            Console.WriteLine(message);





            /* ----- PART 3: String Methods ------------- */

            // String Tests
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char).

            // 0. Those characters can be accessed using [] notation. (but PLEASE use substring instead)
            char firstLetter = name[0];
            char lastLetter = name[name.Length - 1];

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e

            Console.WriteLine("First and Last Character: " + firstLetter + ", " + lastLetter);


            // 2. How do we write code that prints out the first three characters
            // Output: Ada
            string firstThree = name.Substring(0, 3); // Start at index 0, take the first 3 letters

            Console.WriteLine("First 3 characters: " + firstThree.ToUpper());

            // 3. Now print out the last three characters
            // Output: ace

            string lastThree = name.Substring(name.Length - 3, 3);

            Console.WriteLine("Last 3 characters: " + lastThree);


            // 4. What about the last word?
            // Output: Lovelace
            string lastWord = name.Substring(4);

            string[] words = name.Split(" ");
            lastWord = words[1];

            Console.WriteLine("Last Word: " + lastWord);


            // 5. Does the string contain inside of it "Love"?
            // Output: true

            bool hasLove = name.Contains("LOVE");

            Console.WriteLine("Contains \"Love\" " + hasLove);


            // 6. Where does the string "lace" show up in name?
            // Output: 8

            int loveIndex = name.IndexOf("Bobby");

            Console.WriteLine("Index of \"lace\": " + loveIndex);

            int aIndex = name.LastIndexOf("a");
            Console.WriteLine("A Index " + aIndex);

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3

            name = name.ToLower();
            int count = 0;

            for (int i = 0; i < name.Length; i++)
            {
                string letter = name.Substring(i, 1);


                if (letter == "a")
                {
                    count++;
                }
            }

            Console.WriteLine("Number of \"a's\": " + count);

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            name = name.Replace("ada", "sally");

            Console.WriteLine(name);

            // 9. Set name equal to null.
            name = null;

            // 10. If name is equal to null or "", print out "All Done".
            if (name == null || name == "")
            {
                Console.WriteLine("All Done!");
            }
            else
            {
                name = name.ToUpper();
            }

            // Optional Bonus: Show interpolation
            // Optional Bonus: Show escaping strings

            Console.ReadLine();
        }
    }
}
