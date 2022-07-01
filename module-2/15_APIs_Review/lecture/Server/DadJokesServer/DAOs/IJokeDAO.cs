using DadJokesServer.Models;
using System.Collections.Generic;

namespace DadJokesServer.DAOs
{
    public interface IJokeDAO
    {
        Joke AddJoke(Joke newJoke);
        bool DeleteJoke(int id);
        List<Joke> GetAllDadJokes();
        Joke GetJokeById(int id);
        Joke UpdateJoke(Joke joke);
    }
}