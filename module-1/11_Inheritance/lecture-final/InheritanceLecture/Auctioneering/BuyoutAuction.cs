using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class BuyoutAuction : Auction
    {
        public int BuyoutAmount { get; private set; } // The amount the user must enter spend to "buy out" the auction

        public BuyoutAuction(string name, int buyoutAmount)
            : base(name) // Call to the Auction constructor taking in the name, passing our variable like a "hot potato"
        {
            this.BuyoutAmount = buyoutAmount;
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            if (offeredBid.BidAmount >= BuyoutAmount && !HasEnded)
            {
                // Register the bid
                base.PlaceBid(offeredBid);

                // This ends the auction
                EndAuction(); 

                return true;
            }
            else
            {
                // Place the bid as normal
                return base.PlaceBid(offeredBid);
            }
        }
    }
}
