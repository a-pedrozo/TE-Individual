using DadJokesServer.DAOs;
using DadJokesServer.Models;
using DadJokesServer.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadJokesServer.Controllers
{
    /// <summary>
    /// This class must ONLY have endpoints related to authentication. Other endpoints go in other controllers.
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ITokenGenerator tokenGenerator;
        private readonly IPasswordHasher passwordHasher;
        private readonly IUserDAO userDAO;

        public LoginController(ITokenGenerator tokenGenerator, 
            IPasswordHasher passwordHasher, 
            IUserDAO userDAO)
        {
            this.tokenGenerator = tokenGenerator;
            this.passwordHasher = passwordHasher;
            this.userDAO = userDAO;
        }

        [HttpPost]
        public IActionResult Authenticate(LoginInfo userParam)
        {
            // Default to bad username/password message
            IActionResult result = BadRequest("Username or password is incorrect");

            // Get the user by username
            User user = userDAO.GetUser(userParam.Username);

            // If we found a user and the password hash matches
            if (user != null && passwordHasher.VerifyHashMatch(user.PasswordHash, userParam.Password, user.Salt))
            {
                // Create an authentication token
                string token = tokenGenerator.GenerateToken(user.Id, user.Username, user.Role);

                // Create a user object to return to the client
                UserInfo retUser = new UserInfo();
                retUser.UserId = user.Id;
                retUser.Username = user.Username;
                retUser.Role = user.Role;
                retUser.Token = token;

                // Switch to 200 OK
                result = Ok(retUser);
            }

            return result;
        }

        [HttpPost("register")]
        public IActionResult Register(LoginInfo userParam)
        {
            IActionResult result;

            User existingUser = userDAO.GetUser(userParam.Username);
            if (existingUser != null)
            {
                return Conflict("Username already taken. Please choose a different username.");
            }

            string role = "User";
            User user = userDAO.AddUser(userParam.Username, userParam.Password, role);
            if (user != null)
            {
                result = Created(user.Username, null); //values aren't read on client
            }
            else
            {
                result = BadRequest("An error occurred and user was not created.");
            }

            return result;
        }
    }
}
