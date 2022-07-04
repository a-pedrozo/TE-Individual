using DadJokesServer.Models;
using System.Collections.Generic;

namespace DadJokesServer.DAOs
{
    public interface IUserDAO
    {
        User AddUser(string username, string password);
        User GetUser(string username);
        List<User> GetUsers();
    }
}
