using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class BuyoutAuction : Auction
    {
        public int BuyoutAmmount { get; private set; }

        public BuyoutAuction( string name, int buyoutAmount)
            : base(name)
        {
            this.BuyoutAmmount = buyoutAmount;
        }


        public override bool PlaceBid(Bid offeredBid)
        {
            if (offeredBid.BidAmount >= BuyoutAmmount)
            {
                base.PlaceBid(offeredBid);

                EndAuction();

                return true;
            }
            else
            {
                return base.PlaceBid(offeredBid);
            }
        }

    }
}
