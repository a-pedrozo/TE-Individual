using System;
using System.Collections.Generic;
using System.Text;
using DadabaseApp;
using DadabaseApp.Models;
using RestSharp;
using RestSharp.Authenticators;

namespace DadabaseClient.ApiClients
{
    public class DadJokesRestClient
    {
        private readonly RestClient client;

        public DadJokesRestClient()
        {
            this.client = new RestClient("https://localhost:44301/"); // ASP .NET is running on this port
        }

        public List<Joke> GetAllJokes()
        {
            RestRequest request = new RestRequest("jokes");

            IRestResponse<List<Joke>> response = client.Get<List<Joke>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the dad-a-base; Try again later!");

                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Problem getting jokes: " + response.StatusDescription);
                Console.WriteLine(response.Content);

                return null;
            }

            return response.Data;
        }

        public Joke CreateJoke(Joke newJoke)
        {
            RestRequest request = new RestRequest("jokes");
            request.AddJsonBody(newJoke);

            IRestResponse<Joke> response = client.Post<Joke>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the dad-a-base; Try again later!");

                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Problem creating joke: " + response.StatusDescription);
                Console.WriteLine(response.Content);

                return null;
            }

            return response.Data;
        }

        public Joke GetJokeById(int jokeId)
        {
            RestRequest request = new RestRequest("jokes/" + jokeId);

            IRestResponse<Joke> response = client.Get<Joke>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the dad-a-base; Try again later!");

                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Problem getting joke: " + response.StatusDescription);
                Console.WriteLine(response.Content);

                return null;
            }

            return response.Data;
        }

        public Joke UpdateJoke(Joke oldJoke)
        {
            RestRequest request = new RestRequest("jokes/" + oldJoke.Id);

            request.AddJsonBody(oldJoke);

            IRestResponse<Joke> response = client.Put<Joke>(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the dad-a-base; Try again later!");

                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Problem updating joke: " + response.StatusDescription);
                Console.WriteLine(response.Content);

                return null;
            }
            return response.Data;
        }

        public bool DeleteJokeById(int jokeId)
        {
            RestRequest request = new RestRequest("jokes/" + jokeId);
            request.AddHeader("Authorization", "Bearer " + token);

            IRestResponse response = client.Delete(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Could not connect to the dad-a-base; Try again later!");

                return false;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Problem deleting joke: " + response.StatusDescription);
                Console.WriteLine(response.Content);

                return false;
            }

            return response.IsSuccessful;
        }

        public bool HasAuthToken
        {
            get
            {
                return token != null; // TODO: Return true if one is present
            }
        }

        private string token;

        public void UpdateToken(string jwt)
        {
            token = jwt;

            // Any request with this client in the future will AUTOMATICALLY
            // contain the Authorization / Bearer token header
            if (jwt == null)
            {
                client.Authenticator = null;
            }
            else
            {
                client.Authenticator = new JwtAuthenticator(jwt);
            }
        }

    }
}
