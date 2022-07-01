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

        public AuctionsController(IAuctionDao auctionDao)
        {
            dao = auctionDao;
        }

        [HttpGet]
        public List<Auction> List(string title_like = "", double currentBid_lte = 0)
        {
            if (title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }

            return dao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Auction> Get(int id)
        {
            Auction auction = dao.Get(id);
            if (auction != null)
            {
                return Ok(auction);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Auction> Create(Auction auction)
        {
            
            Auction newAuction = dao.Create(auction);

            return Created("/auction/" + newAuction.Id, newAuction);
            
            //return dao.Create(auction); // store this insto variable, then return variable, look for Created method in todays lecutre
        }

        [HttpPut("{id}")]
        public ActionResult<Auction> Update(Auction auction, int id)
        {
            if (id != auction.Id)
            {
                return NotFound();
            }
            Auction updated = dao.Update(id, auction);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public ActionResult<Auction> Delete(int id)
        {
            bool deleted = dao.Delete(id);

            if (deleted)
            {
                return NoContent();
            }
            else
            {
                return NotFound("Could not find reservation with id " + id);
            }
        }
    }
}
