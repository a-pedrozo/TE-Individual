using System;
using System.Collections.Generic;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// This class represents a general auction.
    /// </summary>
    public class Auction
    {
        /// <summary>
        /// This is an encapsulated field that holds all placed bids.
        /// </summary>
        private List<Bid> allBids = new List<Bid>();

        /// <summary>
        /// Creates a new instance of an Auction with the item being a mystery item
        /// </summary>
        public Auction()
        {
            this.AuctionedItem = "Mystery Item";
            this.CurrentHighBid = new Bid("Nobody", 0);
        }

        /// <summary>
        /// Creates a new instance of an Auction with the item name specified
        /// </summary>
        /// <param name="itemName">The name of the item being auctioned off</param>
        public Auction(string itemName)
        {
            this.AuctionedItem = itemName;
            this.CurrentHighBid = new Bid("Nobody", 0);
        }

        public string AuctionedItem { get; }

        /// <summary>
        /// Represents the current high bid.
        /// </summary>
        public Bid CurrentHighBid { get; private set; }

        /// <summary>
        /// Indicates if the auction has ended yet.
        /// </summary>
        public bool HasEnded { get; private set; }

        /// <summary>
        /// All placed bids returned as an array.
        /// </summary>
        public Bid[] AllBids
        {
            get 
            { 
                return allBids.ToArray(); 
            }
        }

        /// <summary>
        /// Ends the current auction
        /// </summary>
        public void EndAuction()
        {
            Console.WriteLine($"The auction is over on the {AuctionedItem}, the winner is {CurrentHighBid.Bidder}");
            HasEnded = true;
        }

        /// <summary>
        /// Places a Bid on the Auction
        /// </summary>
        /// <param name="offeredBid">The bid to place.</param>
        /// <returns>True if the new bid is the current winning bid</returns>
        public bool PlaceBid(Bid offeredBid)
        {
            // Make sure we don't allow bids after auctions are over
            if (HasEnded)
            {
                Console.WriteLine("Cannot accept the bid. The auction has already ended");

                return false;
            }

            // Show the bid details to the user.

            // Record it as a bid by adding it to allBids

            // Check to see IF the offered bid is higher than the current bid amount
            // -- if yes, set offered bid as the current high bid

            // Display the current high bid using ToString

            // Return true if this is the new highest bid, otherwise false
            return offeredBid == CurrentHighBid;
        }
    }
}
