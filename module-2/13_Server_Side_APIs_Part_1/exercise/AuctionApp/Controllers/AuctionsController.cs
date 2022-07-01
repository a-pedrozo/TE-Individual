using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
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

        [HttpGet]
        public List<Auction> ListAuctions(string title_like = null, double currentBid_lte = 0)
        {
            List<Auction> auctions = dao.List();

            //List<Auction> results = dao.SearchByTitleAndPrice(title_like, currentBid_lte);

            if (title_like != null && currentBid_lte > 0)
            {
                List<Auction> results = dao.SearchByTitleAndPrice(title_like, currentBid_lte);
                return results;
            }
            if (title_like != null)
            {
                List<Auction> results = dao.SearchByTitle(title_like);
                return results;
            }
            if (currentBid_lte > 0)
            {
                List<Auction> results = dao.SearchByPrice(currentBid_lte);
                return results;
            }

            return auctions;
        }

        [HttpGet("{auctionId}")]
        public Auction GetAuctionById(int auctionId)
        {
            Auction auction = dao.Get(auctionId);
            return auction;
        }

        [HttpPost]
        public Auction CreateNewAuction([FromBody] Auction newAuction)
        {
            return dao.Create(newAuction);
        }
    }
}
