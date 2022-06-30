using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("/")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionMemoryDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        [HttpGet("auctions")]
        public List<Auction> ListAuctions(string title_like = "", double currentBid_lte = 0)
        {
            List<Auction> auctions = dao.List();

            List<Auction> results = dao.SearchByTitleAndPrice(title_like, currentBid_lte);


            foreach (Auction auction in auctions)
            {
                if (title_like == null || auction.Title == title_like)
                {
                    if (currentBid_lte == 0 || auction.CurrentBid == currentBid_lte)
                    {
                        results.Add(auction);
                        return results;

                    }
                }

            }
            return results;
        }

        [HttpGet("auctions/{auctionId}")]
        public Auction GetAuctionById(int auctionId)
        {
            Auction auction = dao.Get(auctionId);
            return auction;
        }

        [HttpPost("auctions")]
        public Auction CreateNewAuction([FromBody] Auction newAuction)
        {
            return dao.Create(newAuction);
        }
    }
}
