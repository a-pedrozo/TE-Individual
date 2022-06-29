using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("/")] // If there is a specific route here, it gets prepended to any route for a method below
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly HotelMemoryDao hotelDao;
        private readonly ReservationMemoryDao reservationDao;

        public HotelsController()
        {
            // These are "Fake" DAOs that do not talk to the database
            this.hotelDao = new HotelMemoryDao();
            this.reservationDao = new ReservationMemoryDao();
        }

        /// <summary>
        /// This method returns a simple greeting message to show you that ASP .NET works
        /// </summary>
        [HttpGet("greeting")] // Responds to GET requests to /Greeting
        public string HelloWorld()
        {
            return "Hello .NET 17! Welcome to ASP .NET";
        }

        // GET hotels - Get all available hotels
        // GET hotels?state=OH - Get all hotels in Ohio
        // GET hotels?city=Columbus - Get all hotels in Columbus
        // GET hotels?state=OH&city=Columbus - ...
        // NOTE: Query string parameters are not part of your HttpGet attribute
        // NOTE: QUery string parameters are ALWAYS optional
        [HttpGet("hotels")]             // Look for a query string parameter named "state"
        public List<Hotel> GetHotels(string state, string city)
        {
            List<Hotel> hotels = hotelDao.List(); // Pretend this talks to the database

            List<Hotel> results = new List<Hotel>();

            foreach (Hotel hotel in hotels)
            {
                // Did they specify state? If so, do they match?
                if (state == null || hotel.Address.State.ToUpper() == state.ToUpper())
                {
                    // Did they specify city? If so, do they match?
                    if (city == null || hotel.Address.City.ToUpper() == city.ToUpper())
                    {
                        results.Add(hotel);
                    }
                }
            }

            return results;
        }

        /* THIS WILL NEVER WORK
        [HttpGet("hotels")]
        public List<Hotel> GetAllHotelsInState(string state)
        {

        }
        */

        // GET hotels/{someHotelId} - Get a specific hotel
        [HttpGet("hotels/{hotelId}")]
        public Hotel GetHotelById(int hotelId)
        {
            Hotel hotel = hotelDao.Get(hotelId);
 
            return hotel;
        }

        // GET reservations - Get all reservations
        [HttpGet("reservations")]
        public List<Reservation> GetAllReservations()
        {
            return reservationDao.List();
        }

        // GET reservations/{someReservationId} - Get a specific reservation
        [HttpGet("reservations/{id}")]
        public Reservation GetReservationById(int id)
        {
            return reservationDao.Get(id);
        }

        // GET hotels/{someHotelId}/reservations - Get all reservations for a given hotel
        [HttpGet("hotels/{hotelId}/reservations")]
        public List<Reservation> FindReservationsForHotel(int hotelId)
        {
            return reservationDao.FindByHotel(hotelId);
        }

        // GET hotels/filter?
        // GET hotels/filter - Get hotels, but filtered down by state or city based on the query string parameters
        // Query string parameters must be named "state" and "city" respectively

        // POST reservations - Add a new reservation
        [HttpPost("reservations")]
        public Reservation CreateReservation([FromBody] Reservation newReservation)
        {
            return reservationDao.Create(newReservation);
        }
    }
}
