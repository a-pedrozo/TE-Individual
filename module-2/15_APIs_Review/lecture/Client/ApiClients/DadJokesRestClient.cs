using System;
using System.Collections.Generic;
using System.Text;
using DadabaseApp;
using RestSharp;

namespace DadabaseClient.ApiClients
{
    public class DadJokesRestClient
    {
        private readonly RestClient client;

        public DadJokesRestClient()
        {
            this.client = new RestClient("https://localhost:44301/"); // ASP.NET is running on this port, base URL
        }

        public List<Joke> GetAllJokes()
        {
            RestRequest request = new RestRequest("jokes");

            IRestResponse<List<Joke>> response = client.Get<List<Joke>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to dad-a-base");
                return null;
            }
            if (!response.IsSuccessful)
            {
                Console.WriteLine("Problem getting jokes: " + response.StatusDescription);
            }
            return response.Data;

        }

        public Joke CreateJoke(Joke newJoke)
        {
            RestRequest request = new RestRequest("jokes");
            request.AddJsonBody(newJoke);

            IRestResponse<Joke> response = client.Post<Joke>(request);

            // ToDO error handling goes here! Ommitted for lecture length purposes

            return response.Data;
        }

        public Joke GetJokeById(int jokeId)
        {
            RestRequest request = new RestRequest("jokes/" + jokeId);

            IRestResponse<Joke> response = client.Get<Joke>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to dad-a-base");
                return null;
            }
            if (!response.IsSuccessful)
            {
                Console.WriteLine("Problem getting joke: " + response.StatusDescription);
            }
            return response.Data;
        }

        public Joke UpdateJoke(Joke oldJoke)
        {
            RestRequest request = new RestRequest("jokes/" + oldJoke.Id);
            request.AddJsonBody(oldJoke);

            IRestResponse<Joke> response = client.Put<Joke>(request);

            // ToDO error handling goes here! Ommitted for lecture length purposes

            return response.Data;
        }

        public bool DeleteJokeById(int jokeId)
        {
            RestRequest request = new RestRequest("jokes/" + jokeId);

            IRestResponse response = client.Delete(request);

            return response.IsSuccessful;
        }
    }
}
