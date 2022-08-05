using System.Collections.Generic;
using Capstone.Models;

namespace Capstone.DAO
{
    public interface IUserDAO
    {
        User GetUser(string username);
        List<ReturnUser> GetUsers();
        User AddUser(string username, string password, string role);
    }
}
