using DadJokesServer.DAOs;
using DadJokesServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadJokesServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokesController : ControllerBase
    {
        private readonly IDadDAO dadDAO;
        private readonly JokeDAO jokeDAO;

        public JokesController(IDadDAO dadDAO, JokeDAO jokeDAO)
        {
            this.dadDAO = dadDAO;
            this.jokeDAO = jokeDAO;
        }

        [HttpGet]
        public ActionResult GetJokes()
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
                return NotFound();
            }

            return Ok(joke);
        }

        [HttpPost]
        public ActionResult AddJoke(Joke joke)
        {
            Joke newJoke = jokeDAO.AddJoke(joke);

            return Created("api/jokes/" + joke.Id, newJoke);
        }

        [HttpPut]
        public ActionResult UpdateJoke(Joke joke)
        {
            Joke updated = jokeDAO.UpdateJoke(joke);

            if (updated == null)
            {
                return NotFound();
            }

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteJoke(int id)
        {
            bool deleted = jokeDAO.DeleteJoke(id);

            return NoContent();
        }
    }
}
