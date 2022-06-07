using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class TicketPurchase
    {
        public string Name { get; }
        public int NumOfTickets { get; }
        
        public decimal BasePrice
        {
            get
            {
                decimal basePrice = NumOfTickets * 59.99m;
                return basePrice;
            }
        }

        public TicketPurchase(string name, int numOfTickets)
        {
            this.Name = name;
            this.NumOfTickets = numOfTickets;
        }

        public decimal Surcharge(bool earlyCheckIn,bool priorityRideAccess)
        {
            decimal earlyCheckinCharge = 10.00m;
            decimal priorityRideAccessCharge = 50.00m;
            if(earlyCheckIn == true && priorityRideAccess == true)
            {
                return BasePrice + earlyCheckinCharge + priorityRideAccessCharge;
            }
            else if(earlyCheckIn == true)
            {
                return BasePrice + earlyCheckinCharge;
            }
            else if(priorityRideAccess == true)
            {
                return BasePrice + priorityRideAccessCharge;
            }
            else 
            return BasePrice;
        }

    }
}
