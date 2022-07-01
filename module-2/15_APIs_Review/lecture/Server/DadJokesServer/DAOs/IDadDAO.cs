using DadJokesServer.Models;
using System.Collections.Generic;

namespace DadJokesServer.DAOs
{
    public interface IDadDAO
    {
        bool DeleteDad(int dadId);
        Dad GetDadById(int dadId);
        Dad GetDadByName(string name);
        List<Dad> GetDads();
        Dad InsertDad(string dadName);
        Dad UpdateDad(Dad dad);
    }
}
