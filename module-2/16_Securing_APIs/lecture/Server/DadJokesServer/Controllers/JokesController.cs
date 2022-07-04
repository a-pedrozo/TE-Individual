using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DadJokesServer.DAOs;
using DadJokesServer.Models;
using Microsoft.AspNetCore.Authorization;

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

        [AllowAnonymous]
        [HttpGet] // GET Jokes
        public ActionResult GetAllJokes()
        {
            List<Joke> jokes = jokeDAO.GetAllDadJokes();

            return Ok(jokes);
        }

        [AllowAnonymous]
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

        [Authorize]
        [HttpPost]
        public ActionResult CreateJoke(Joke joke)
        {
            Joke createdJoke = jokeDAO.AddJoke(joke);

            return Ok(createdJoke); // or Created("jokes/" + createdJoke.Id, createdJoke);
        }

        [Authorize]
        [HttpPut("{jokeId}")]
        public ActionResult UpdateJoke(int jokeId, [FromBody] Joke joke)
        {
            if (jokeId != joke.Id)
            {
                return BadRequest("The joke ID did not match. Nice try hacker!");
            }

            Joke updated = jokeDAO.UpdateJoke(joke);

            if (updated == null)
            {
                return NotFound("Could not find joke " + jokeId);
            }

            return Ok(updated);
        }

        [Authorize]
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
    }
}
