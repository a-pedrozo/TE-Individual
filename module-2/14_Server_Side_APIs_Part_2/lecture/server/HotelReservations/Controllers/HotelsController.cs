using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelDao hotelDao;
        private readonly IReservationDao reservationDao;

        public HotelsController(IHotelDao hotelDao, IReservationDao reservationDao)
        {
            this.hotelDao = hotelDao;
            this.reservationDao = reservationDao;
        }

        [HttpGet("hotels")]
        public ActionResult ListHotels()
        {
            List<Hotel> hotels = hotelDao.List();
            return Ok(hotels); // 200 ok stats
        }

        [HttpGet("hotels/{id}")]
        public ActionResult GetHotel(int id)
        {
            Hotel hotel = hotelDao.Get(id);

            // TODO: What if hotel is null? How do we return a 404?
            if (hotel == null)
            {
                return NotFound("Could not find hotel " + id);
            }
            // TODO: What happens if we get an exception here?
            if (hotel.Address.State != "OH")
            {
                int divisor = 0;
                int answer = 42 / divisor; // this will break
            }

            return Ok(hotel);
        }

        [HttpGet("hotels/filter")]
        public ActionResult FilterByStateAndCity(string state, string city)
        {
            List<Hotel> filteredHotels = new List<Hotel>();

            List<Hotel> hotels = hotelDao.List();

            // return hotels that match state
            foreach (Hotel hotel in hotels)
            {
                if (city == null || city.ToUpper() == hotel.Address.City.ToUpper())
                {
                    if (state == null || state.ToUpper() == hotel.Address.State.ToUpper()) 
                    { 
                        filteredHotels.Add(hotel);
                    }
                }
            }

            return Ok(filteredHotels);
        }

        [HttpGet("hotels/{hotelId}/reservations")]
        public ActionResult ListReservationsByHotel(int hotelId)
        {
            // TODO: What if the ID is negative?
            if (hotelId <= 0)
            {
                return BadRequest("hotelId must be postitive but was " + hotelId);
            }
            // TODO: What if they give us a hotel that doesn't exist?
            Hotel hotel = hotelDao.Get(hotelId);
            if (hotel == null)
            {
                return NotFound("Could not find hotel " + hotelId);
            }
            return Ok(reservationDao.FindByHotel(hotelId));
        }
    }
}
