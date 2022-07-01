using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationDao reservationDao;

        public ReservationsController(IReservationDao reservationDao)
        {
            this.reservationDao = reservationDao;
        }

        [HttpGet] // Reservations
        public ActionResult ListReservations()
        {
            return Ok(reservationDao.List());
        }

        [HttpGet("{id}")] // Reservations/42
        public ActionResult GetReservation(int id)
        {
            Reservation reservation = reservationDao.Get(id);

            // TODO: What if reservation is null? How do we return a 404?
            if (reservation == null)
            {
                return NotFound("Cound not find reservation " + id);
            }
            return Ok(reservation);
        }

        [HttpPost] // Reservations
        public ActionResult AddReservation(Reservation reservation)
        {
            Reservation newReservation = reservationDao.Create(reservation);

            // TODO: How do we give back a 201 created instead?
            return Created("/reservations/" + newReservation.Id, newReservation);
            //return Ok(newReservation);
        }

        // Let's add validation to our Reservation model

        // PUT reservations/{id}
        [HttpPut("{id}")]
        //Getting reservation from the request body, getting id from the URL
        public ActionResult UpdateReservation(Reservation reservation, int id)
        {
            if (id != reservation.Id)
            {
                return BadRequest("ID and Reservation ID no not match");
            }
            Reservation updated = reservationDao.Update(id, reservation);

            return Ok(updated);
        }
        // DELETE reservations/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteReservation(int id)
        {
            bool deleted = reservationDao.Delete(id);

            if (deleted)
            {
                return NoContent(); // typically no body for NoContent 
            }
            else
            {
                return NotFound("Could not find reservation with id " + id);
            }

        }
        // If time allows...
        // Let's also add a TeapotController with a GET to get a 418 status code. For science!
    }
}
