using DadJokesServer.Models;
using System.Collections.Generic;

namespace DadJokesServer.DAOs
{
    public interface IUserDAO
    {
        User AddUser(string username, string password, string role);
        User GetUser(string username);
        List<User> GetUsers();
    }
}
