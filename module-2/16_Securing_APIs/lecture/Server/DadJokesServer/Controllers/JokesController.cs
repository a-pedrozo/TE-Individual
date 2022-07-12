using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DadJokesServer.DAOs;
using DadJokesServer.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace DadJokesServer.Controllers
{
    [Route("[controller]")] // can rename to "jokes" will be same as [controller], can also replace wtih / but will need to enter in jokes/ in every [Http]
    [ApiController]
    [Authorize]
    public class JokesController : ControllerBase
    {
        private readonly IJokeDAO jokeDAO;

        public JokesController(IJokeDAO jokeDAO)
        {
            this.jokeDAO = jokeDAO;
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, Moderator")] // only authenticated users ,passing a valid JWT, can call this. passing paramaters for roles this is Authorization
        public ActionResult DeleteAJoke(int id)
        {
            bool deleted = jokeDAO.DeleteJoke(id);

            if (deleted)
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet] // GET Jokes
        [AllowAnonymous]
        public ActionResult GetAllJokes()
        {
            List<Joke> jokes = jokeDAO.GetAllDadJokes();

            return Ok(jokes);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public ActionResult GetJoke(int id)
        {
            Joke joke = jokeDAO.GetJokeById(id);

            if (joke == null)
            {
                return NotFound("Could not find joke " + id);
            }

            return Ok(joke);
        }

        [HttpPost]
        [Authorize]
        public ActionResult CreateJoke(Joke joke)
        {
           

            // TODO: Let's explore User.Identity.Name
            string username = User.Identity.Name; // built int ASP.NET gets the name from JWT

            // TODO: Associate the joke with the user's logged in name
            int id = LoggedInUserId; // a custom derived property, defined below

            // this ID came from JWT's "sub" claim. sub == subject or the ID of the user 
            joke.UserId = id;

            Joke createdJoke = jokeDAO.AddJoke(joke);

            return Ok(createdJoke); // or Created("jokes/" + createdJoke.Id, createdJoke);
        }

        /// <summary>
        /// Gets and returns the ID of the logged in user from their JWT.
        /// This will return -1 if the user is not logged in.
        /// </summary>
        private int LoggedInUserId
        {
            get
            {
                Claim idClaim = User.FindFirst("sub");
                if (idClaim == null)
                {
                    // User is not logged in
                    return -1;
                }
                else
                {
                    // User is logged in. Their subject (sub) claim is their ID
                    return int.Parse(idClaim.Value);
                }
            }
        }

        [HttpPut("{jokeId}")]
        [Authorize]
        public ActionResult UpdateJoke(int jokeId, [FromBody] Joke joke)
        {
            if (jokeId != joke.Id)
            {
                return BadRequest("The joke ID did not match. Nice try hacker!");
            }

            Joke originalJoke = jokeDAO.GetJokeById(jokeId);
            if (originalJoke == null)
            {
                return NotFound("Could not find joke " + jokeId);
            }

            int userId = LoggedInUserId; // only works on controllers, this is how to set individual ids to access certian method 
            
            // TODO: Only admins or the creators of the joke should be able to do this
            if (originalJoke.UserId != userId)
            {
                return Forbid("you are not the creator of this joke"); //403 forbidden states that this action is not authorized 
            }

            Joke updated = jokeDAO.UpdateJoke(joke);

            return Ok(updated);
        }
    }
}
