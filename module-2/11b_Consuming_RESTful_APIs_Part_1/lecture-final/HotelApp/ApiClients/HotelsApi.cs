using RestSharp;
using System;
using System.Collections.Generic;

namespace HTTP_Web_Services_GET_lecture.ApiClients
{
    public class HotelsApi
    {
        private readonly RestClient client;
        private readonly string baseUrl;

        public HotelsApi(string laptopNumber)
        {
            this.client = new RestClient(); // RestClient makes requests and gets responses for us from APIs

            // See https://te-mockauction-server.azurewebsites.net/swagger/index.html for API Documentation

            this.baseUrl = "https://te-mockauction-server.azurewebsites.net/students/" + laptopNumber + "/";
        }

        public List<Hotel> GetAllHotels()
        {
            // Make a GET request to the /student/#/hotels endpoint
            RestRequest request = new RestRequest(baseUrl + "hotels"); // Build the request to send

            IRestResponse<List<Hotel>> response; // This will hold a response with data that is a list of Hotel objects

            // Make the GET request and get back the response
            response = client.Get<List<Hotel>>(request);

            List<Hotel> data = response.Data;

            return data;
        }

        public List<Reservation> GetAllReservations()
        {
            RestRequest request = new RestRequest(baseUrl + "reservations");

            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            return response.Data;
        }

        public Hotel GetHotel(int hotelId)
        {
            RestRequest request = new RestRequest(baseUrl + "hotels/" + hotelId);

            IRestResponse<Hotel> response = client.Get<Hotel>(request);

            return response.Data;
        }

        public List<Reservation> GetReservationsForHotel(int hotelId)
        {
            RestRequest request = new RestRequest(baseUrl + "hotels/" + hotelId + "/reservations");

            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            return response.Data;
        }

        public List<Hotel> GetAllHotelsInState(string state)
        {
            RestRequest request = new RestRequest(baseUrl + "hotels/filter?state=" + state);

            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            return response.Data;
        }

    }
}
