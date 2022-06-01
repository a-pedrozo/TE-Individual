using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
   public class ReserveAuction : Auction // : = inherits from . ReserveAuction inherits from Auction
                                            // when resserve auction is created, call Auction's parameterless constructor (base())
    {
        public int BuyoutThreshold { get; set; }

        public ReserveAuction(int threshold): base() // calling consuctor from base or parent class. :base = call my parents constructor. can choose which constuctor is being called
        {
            this.BuyoutThreshold = threshold;
        }

        public ReserveAuction(string nameOfAuctionItem, int threshold)
            :base(nameOfAuctionItem)
        {
            this.BuyoutThreshold = threshold;
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            if (offeredBid.BidAmount > BuyoutThreshold)
            {
                Console.WriteLine("this is a reserve auction place bid");

                return base.PlaceBid(offeredBid);
            }
            else
            {
                offeredBid.DisplayDetails();
                Console.WriteLine("Sorry cheapskate");
                return false;
            }
        }
    }
}
