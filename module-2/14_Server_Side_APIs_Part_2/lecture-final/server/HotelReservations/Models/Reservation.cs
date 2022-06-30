using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservations.Models
{
    public class Reservation
    {
        public int? Id { get; set; }

        // TODO: Mark some of these fields as required

        // TODO: What happens if the set is private?
        [Range(1, int.MaxValue)] // Between 1 and the largest number we can store
        public int HotelId { get; set; }

        // TODO: Use a string length validation on FullName
        [Required] // Required says it cannot be null
        [StringLength(10)] // Any string > 10 characters long is invalid
        public string FullName { get; set; }

        [Required(ErrorMessage = "Yo! Give me a check in date, so I can check you in!")]
        public string CheckinDate { get; set; }

        [Required]
        public string CheckoutDate { get; set; }

        // TODO: Add range validation to this to restrict the guest count to between 1 and 5 guests
        [Range(1, 5, ErrorMessage = "Squirrels")]
        public int Guests { get; set; }

        public Reservation() // TODO: What happens if we don't have a parameterless reservation constructor?
        {
        }

        public Reservation(int? id, int hotelId, string fullName, string checkinDate, string checkoutDate, int guests)
        {
            Id = id ?? new Random().Next(100, int.MaxValue);
            HotelId = hotelId;
            FullName = fullName;
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
            Guests = guests;
        }
    }
}
