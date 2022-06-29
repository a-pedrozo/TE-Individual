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

        // GET hotels/{someHotelId} - Get a specific hotel

        // GET reservations - Get all reservations

        // GET reservations/{someReservationId} - Get a specific reservation

        // GET hotels/{someHotelId}/reservations - Get all reservations for a given hotel

        // GET hotels/filter - Get hotels, but filtered down by state or city based on the query string parameters
        // Query string parameters must be named "state" and "city" respectively

        // POST reservations - Add a new reservation
    }
}
