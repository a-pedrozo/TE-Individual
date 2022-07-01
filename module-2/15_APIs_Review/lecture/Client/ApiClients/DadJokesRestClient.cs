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
            this.client = new RestClient("https://localhost:44301/");
        }

        public List<Joke> GetAllJokes()
        {
            RestRequest request = new RestRequest("api/jokes");

            IRestResponse<List<Joke>> response = client.Get<List<Joke>>(request);

            return response.Data;
        }

        public Joke CreateJoke(Joke newJoke)
        {
            RestRequest request = new RestRequest("api/jokes");
            request.AddJsonBody(newJoke);

            IRestResponse<Joke> response = client.Post<Joke>(request);

            return response.Data;
        }

        public Joke GetJokeById(int jokeId)
        {
            RestRequest request = new RestRequest("api/jokes/" + jokeId);

            IRestResponse<Joke> response = client.Get<Joke>(request);

            return response.Data;
        }

        public Joke UpdateJoke(Joke oldJoke)
        {
            RestRequest request = new RestRequest("api/jokes/");
            request.AddJsonBody(oldJoke);

            IRestResponse<Joke> response = client.Put<Joke>(request);

            return response.Data;
        }

        public bool DeleteJokeById(int jokeId)
        {
            RestRequest request = new RestRequest("api/jokes/" + jokeId);

            IRestResponse response = client.Delete(request);

            return response.IsSuccessful;
        }
    }
}
