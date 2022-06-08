using System;

namespace Assessment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create an object and call methods on it (manual testing) from this class.
            // You DO NOT need to prompt the user to type in any values

            TicketPurchase classTickets = new TicketPurchase("John", 19); // creating instance of classs
            classTickets.Surcharge(true, true);

            decimal jonhsFee = classTickets.Surcharge(true, true); // applying method to new instance and creating variable out of it 
            Console.WriteLine(jonhsFee.ToString("C"));

            Console.WriteLine(classTickets); // automatically calls to string 


            



        }


    }
}
