using System;

namespace Assessment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create an object and call methods on it (manual testing) from this class.
            // You DO NOT need to prompt the user to type in any values

            TicketPurchase classTickets = new TicketPurchase("John", 19);

            classTickets.Surcharge(true, true);
            decimal baseTotal = classTickets.BasePrice * classTickets.NumOfTickets;
            Console.WriteLine(baseTotal);




            //    public override string ToString()
            //{
            //    return $" TICKET {} - {baseTotal}";
            //}










        }


    }
}
