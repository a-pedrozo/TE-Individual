using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class ReserveAuction : Auction  //Colon tells it it's inheriting from the auction class.
    {
        public int BuyoutThreshold { get; set; }

        // When reserve auction is created, call Auction's
        // parameterless constructor (base())
        public ReserveAuction(int threshold)
            : base() // calls the parent constructor
        {
            this.BuyoutThreshold = threshold;
        }

        public ReserveAuction(string nameOfAuctionedItem, int threshold)
            : base(nameOfAuctionedItem) // Call the constructor that takes in a single name.
        {
            this.BuyoutThreshold = threshold;
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            if (offeredBid.BidAmount > BuyoutThreshold) {
                Console.WriteLine("This is a reserve auction place bid");

                return base.PlaceBid(offeredBid); // Call the non-overridden version of PlaceBid in Auction.cs
            }
            else
            {
                offeredBid.DisplayDetails();
                Console.WriteLine("Sorry cheapskate!");

                return false;
            }
        }
    }
}
