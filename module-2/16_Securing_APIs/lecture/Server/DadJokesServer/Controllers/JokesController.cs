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
    [Route("[controller]")]
    [ApiController]
    public class JokesController : ControllerBase
    {
        private readonly IJokeDAO jokeDAO;

        public JokesController(IJokeDAO jokeDAO)
        {
            this.jokeDAO = jokeDAO;
        }

        [HttpDelete("{id}")]
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
        public ActionResult GetAllJokes()
        {
            List<Joke> jokes = jokeDAO.GetAllDadJokes();

            return Ok(jokes);
        }

        [HttpGet("{id}")]
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
        public ActionResult CreateJoke(Joke joke)
        {
            return StatusCode(StatusCodes.Status501NotImplemented, "We need to update this!");

            // TODO: Let's explore User.Identity.Name

            // TODO: Associate the joke with the user's logged in name

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

            // TODO: Only admins or the creators of the joke should be able to do this

            Joke updated = jokeDAO.UpdateJoke(joke);

            return Ok(updated);
        }
    }
}
