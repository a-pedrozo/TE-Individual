using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
    public class Program
    {
        public static void Main() // this is start of application, 
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            Auction generalAuction = new Auction("Up"); // instanciating action variable 

            generalAuction.PlaceBid(new Bid("Matt", 1));
            generalAuction.PlaceBid(new Bid("Rick Astley", 10));
            generalAuction.PlaceBid(new Bid("John", 13));

            Bid ricksSecondBid = new Bid("Rick Astley", 500);
            generalAuction.PlaceBid(ricksSecondBid);
            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids
            generalAuction.EndAuction();

            // Create a new ReserveAuction (buyer can reject small bids)
            ReserveAuction bmwAuction = new ReserveAuction("BMW", 500); // inherets eveything inside of auction

            bmwAuction.PlaceBid(new Bid("Matt", 1));
            bmwAuction.PlaceBid(new Bid("Dan", 15000));
            
            bmwAuction.EndAuction();

            // Create a new BuyoutAuction (big bids can end the auction)
            BuyoutAuction twelvePack = new BuyoutAuction("12 pack", 50);
            
            twelvePack.PlaceBid(new Bid("Jimothey", 3));
            twelvePack.PlaceBid(new Bid("Matt", 4));
            twelvePack.PlaceBid(new Bid("Jimothey", 5));
            twelvePack.PlaceBid(new Bid("James", 10));
            twelvePack.PlaceBid(new Bid("brian", 75));
            twelvePack.PlaceBid(new Bid("Matt", 80));

            twelvePack.EndAuction();



            Console.WriteLine();
            Console.WriteLine("No more auctions!");
            Console.ReadLine();
        }
    }
}
