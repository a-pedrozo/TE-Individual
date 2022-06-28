using RestSharp;
using System;
using System.Collections.Generic;

namespace HTTP_Web_Services_POST_PUT_DELETE_lecture.ApiClients
{
    public class ReservationsService
    {
        private readonly RestClient client;

        public ReservationsService(string base_url)
        {
            // This base_url is automatically added to the beginning of every request made with this RestClient
            this.client = new RestClient(base_url); // Looks like https://te-mockauction-server.azurewebsites.net/students/42/
        }

        public List<Hotel> GetHotels()
        {
            RestRequest request = new RestRequest("hotels"); // baseUrl + "hotels"

            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            // What happens if we can't connect?
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the server to get hotels");
                return null;
            }

            // What happens if we get a 400 or 500 series error code from the server?
            if (!response.IsSuccessful)
            {
                Console.WriteLine("Error communicating with server to get hotels: " + response.StatusDescription);
                return null;
            }

            return response.Data;
        }

        public List<Reservation> GetReservations(int hotelId)
        {
            RestRequest request = new RestRequest($"hotels/{hotelId}/reservations");

            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            return response.Data;
        }

        public List<Reservation> GetReservations()
        {
            RestRequest request = new RestRequest("reservations");

            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            return response.Data;
        }

        public Reservation GetReservation(int reservationId)
        {
            // GET https://te-mockauction-server.azurewebsites.net/students/Eland/reservations/2

            RestRequest request = new RestRequest("reservations/" + reservationId);

            IRestResponse<Reservation> response = client.Get<Reservation>(request);

            return response.Data; // Data is set by deserializing the response body JSON into a C# object
        }

        public Reservation AddReservation(Reservation newReservation)
        {
            // POST to reservations with a Body of JSON for the reservation
            RestRequest request = new RestRequest("reservations");

            // Next we need to set the JSON Body of the request
            request.AddJsonBody(newReservation); // Serialize newReservation to JSON and put it in the request body

            // Make the request
            IRestResponse<Reservation> response = client.Post<Reservation>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not communicate with server; please try again.");
                return null;
            }

            if (!response.IsSuccessful) // Status Code NOT 200 - 299
            {
                Console.WriteLine("Could not create reservation: " + response.StatusDescription);
                return null;
            }

            return response.Data;
        }

        public Reservation UpdateReservation(Reservation reservationToUpdate)
        {
            // POST to reservations with a Body of JSON for the reservation
            RestRequest request = new RestRequest("reservations/" + reservationToUpdate.Id);

            // Next we need to set the JSON Body of the request
            request.AddJsonBody(reservationToUpdate); // Serialize newReservation to JSON and put it in the request body

            request.AddHeader("is-awesome", "true");

            // Make the request
            IRestResponse<Reservation> response = client.Put<Reservation>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not communicate with server; please try again.");
                return null;
            }

            if (!response.IsSuccessful) // Status Code NOT 200 - 299
            {
                Console.WriteLine("Could not update reservation: " + response.StatusDescription);
                return null;
            }

            return response.Data;
        }

        public void DeleteReservation(int reservationId)
        {
            RestRequest request = new RestRequest("reservations/" + reservationId);

            // Since this method does not return anything, we don't need to use IRestResponse<T>
            IRestResponse response = client.Delete(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the server; please try again.");
                return;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Could not delete the reservation: " + response.StatusDescription);
                return;
            }
        }
    }
}
