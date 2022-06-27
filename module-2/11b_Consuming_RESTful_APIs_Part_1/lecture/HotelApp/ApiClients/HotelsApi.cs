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
            this.client = new RestClient(); //RestClient makes requests and gets response for us from APIs

            // See https://te-mockauction-server.azurewebsites.net/swagger/index.html for API Documentation

            this.baseUrl = "https://te-mockauction-server.azurewebsites.net/students/" + laptopNumber + "/";
        }

        public List<Hotel> GetAllHotels()
        {
            // make a GET request to the /student/#/hotels endpoint 
            RestRequest request = new RestRequest(baseUrl + "hotels"); // building request to send 

            IRestResponse<List<Hotel>> response; //this will hold a response with data that is a list of Hotel objects

            // Makes the GET reqeust and get back the Response 
            response = client.Get<List<Hotel>>(request);

            List<Hotel> data = response.Data; // makes list of  data into a variable
            return data;
        }

        public List<Reservation> GetAllReservations()
        {
            RestRequest resquest = new RestRequest(baseUrl + "reservations"); //URL search from Postman, will use for hw 

            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(resquest); // does all the code work, make sure to use <>brackets correctly 

            return response.Data;
        }

        public Hotel GetHotel(int hotelId)
        {
            RestRequest resquest = new RestRequest(baseUrl + "hotels/" + hotelId); //building request to send, paramaters are for getting single hotel

            IRestResponse<Hotel> response = client.Get<Hotel>(resquest); // holds response of data that is a single object 

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
            RestRequest request = new RestRequest(baseUrl + "hotels/filter?state=" + state); // created string from postman

            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            return response.Data;
        }

    }
}
