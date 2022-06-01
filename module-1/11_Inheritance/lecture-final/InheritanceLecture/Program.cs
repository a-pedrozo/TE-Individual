using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
    public class Program
    {
        public static void Main() /*This starts most console applications*/
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            Auction generalAuction = new Auction("Up");

            generalAuction.PlaceBid(new Bid("Matt", 1)); 
            generalAuction.PlaceBid(new Bid("Rick Astley", 10));
            generalAuction.PlaceBid(new Bid("John", 13));

            Bid ricksSecondBid = new Bid("Rick Astley", 500);
            generalAuction.PlaceBid(ricksSecondBid);

            generalAuction.PlaceBid(new Bid("Matt", 2));

            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids
            generalAuction.EndAuction();

            Console.WriteLine();

            // Create a new ReserveAuction (buyer can reject small bids)
            ReserveAuction bmwAuction = new ReserveAuction("BMW", 500);

            bmwAuction.PlaceBid(new Bid("Matt", 1)); // Shouldn't be allowed
            bmwAuction.PlaceBid(new Bid("Dan", 33000));

            bmwAuction.EndAuction();

            Console.WriteLine();

            // Create a new BuyoutAuction (big bids can end the auction)
            BuyoutAuction twelvePack = new BuyoutAuction("12 Pack", 50);

            twelvePack.PlaceBid(new Bid("Jimothy", 3));
            twelvePack.PlaceBid(new Bid("Matt", 4));
            twelvePack.PlaceBid(new Bid("Brian", 5));
            twelvePack.PlaceBid(new Bid("Matt", 75)); // Buys out the auction
            twelvePack.PlaceBid(new Bid("Dan", 76)); // Shouldn't be accepted

            twelvePack.EndAuction();

            Console.WriteLine();
            Console.WriteLine("No more auctions!");
            Console.ReadLine();
        }
    }
}
