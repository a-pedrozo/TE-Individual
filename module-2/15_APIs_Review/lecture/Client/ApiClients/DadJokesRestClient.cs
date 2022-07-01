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
            throw new NotImplementedException();
        }

        public Joke CreateJoke(Joke newJoke)
        {
            throw new NotImplementedException();
        }

        public Joke GetJokeById(int jokeId)
        {
            throw new NotImplementedException();
        }

        public Joke UpdateJoke(Joke oldJoke)
        {
            throw new NotImplementedException();
        }

        public bool DeleteJokeById(int jokeId)
        {
            throw new NotImplementedException();
        }
    }
}
