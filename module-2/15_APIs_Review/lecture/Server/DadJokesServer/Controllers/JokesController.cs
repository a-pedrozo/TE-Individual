using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DadJokesServer.DAOs;
using DadJokesServer.Models;

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

        [HttpGet] // GET jokes
        public ActionResult GetAllJoeks()
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
        public ActionResult CreateAJoke(Joke joke)
        {
            Joke createdJoke= jokeDAO.AddJoke(joke);
            return Ok(createdJoke);

        }

        [HttpPut("{id}")]
        public ActionResult UpdateJoke(int jokeId, Joke joke)
        {
            Joke updated = jokeDAO.UpdateJoke(joke);

            if (jokeId != joke.Id)
            {
                return BadRequest("the joke ID did not match");
            }

            if (updated == null)
            {
                return NotFound( "could not find joke " + jokeId);
            }

            return Ok(updated);
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
    }
}
