using HotelReservations.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelReservations.Dao
{
    public class ReservationMemoryDao : IReservationDao
    {
        private static List<Reservation> Reservations { get; set; }

        public ReservationMemoryDao()
        {
            InitializeReservationData();
        }

        private void InitializeReservationData()
        {
            if (Reservations == null || Reservations.Count == 0)
            {
                Reservations = new List<Reservation>(new Reservation[] {
                        new Reservation(1, 1, "John Smith", DateTime.Today.ToString(), DateTime.Today.AddDays(3).ToString(), 2),
                        new Reservation(2, 1, "Sam Turner", DateTime.Today.ToString(), DateTime.Today.AddDays(5).ToString(), 4),
                        new Reservation(3, 1, "Mark Johnson", DateTime.Today.AddDays(7).ToString(), DateTime.Today.AddDays(10).ToString(), 2),
                        new Reservation(4, 2, "Jospeh Williams", DateTime.Today.AddDays(2).ToString(), DateTime.Today.AddDays(4).ToString(), 2) 
                    });
            }
        }

        public List<Reservation> List()
        {
            return Reservations;
        }

        public Reservation Get(int id)
        {
            foreach (var reservation in Reservations)
            {
                if (reservation.Id == id)
                {
                    return reservation;
                }
            }

            return null;
        }

        public List<Reservation> FindByHotel(int hotelId)
        {
            List<Reservation> matched = new List<Reservation>();
            foreach (Reservation r in Reservations)
            {
                if (r.HotelId == hotelId)
                {
                    matched.Add(r);
                }
            }
            return matched;
        }

        public Reservation Create(Reservation reservation)
        {
            int nextId = 1;
            foreach (Reservation oldReservation in Reservations)
            {
                if (oldReservation.Id.HasValue && oldReservation.Id > nextId)
                {
                    nextId = oldReservation.Id.Value + 1;
                }
            }
            
            reservation.Id = nextId;
            Reservations.Add(reservation);

            return reservation;
        }

        public Reservation Update(int id, Reservation updated)
        {
            Reservation old = Get(id);

            if (old == null)
            {
                return null;
            }

            updated.Id = old.Id;

            Reservations.Remove(old);
            Reservations.Add(updated);

            return updated;
        }

        public bool Delete(int id)
        {
            Reservation old = Get(id);
            if (old == null)
            {
                return false;
            }

            Reservations.Remove(old);

            return true;
        }
    }
}
