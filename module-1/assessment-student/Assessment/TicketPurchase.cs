using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class TicketPurchase // class representing set of tickets 
    {
        // name of person buying tickets
        public string Name { get; }
        // number of tickets purchased 
        public int NumOfTickets { get; }

        public decimal BasePrice // derived property base purchase price for num of tickets 
        {
            get
            {
                // decimal basePrice = NumOfTickets * 59.99m; code I wrote before 
                return NumOfTickets * 59.99m;
            }
        }

        public TicketPurchase(string name, int numOfTickets) // could apply throw exception for negative values 
        {
            this.Name = name;
            this.NumOfTickets = numOfTickets;
        }

        public decimal Surcharge(bool earlyCheckIn, bool priorityRideAccess)
        {
            const decimal earlyCheckinCharge = 10.00m;
            const decimal priorityRideAccessCharge = 50.00m;
            decimal price = BasePrice; // start with base price for # of people can do independant if statements 

           
            if (earlyCheckIn == true)
            {
                price += earlyCheckinCharge * NumOfTickets;
            }
            if (priorityRideAccess == true)
            {
                price += priorityRideAccessCharge * NumOfTickets; // correct math of adding tickets
            }
            return price; 
        }

        public override string ToString()
        {
            return $"TICKET - {this.Name} - {BasePrice.ToString("C")}";
        }


    }
}
