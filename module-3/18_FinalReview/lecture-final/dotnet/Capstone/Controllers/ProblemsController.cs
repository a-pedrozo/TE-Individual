using Capstone.DAO;
using Capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProblemsController : ControllerBase
    {
        private ITrolleyDAO trolleyDAO;

        public ProblemsController(ITrolleyDAO trolleyDAO)
        {
            this.trolleyDAO = trolleyDAO;
        }

        [HttpGet()] // GET to api/problems
        public ActionResult ListProblems()
        {
            List<TrolleyProblem> problems = trolleyDAO.LoadAllProblems();

            return Ok(problems);
        }

        [HttpGet("{id}")] // GET to api/problems/{id}
        public ActionResult GetProblem(int id)
        {
            TrolleyProblem problem = trolleyDAO.LoadProblemById(id);

            if (problem == null)
            {
                return NotFound(problem);
            }

            return Ok(problem);
        }

        [Authorize]
        [HttpPut("{id}")] // PUT to api/problems
        // We are getting TrolleyProblem from the message body
        public ActionResult UpdateProblem(int id, TrolleyProblem problem)
        {
            if (id != problem.Id)
            {
                return BadRequest();
            }

            trolleyDAO.Update(problem);

            // Reload it from the database and return it
            problem = trolleyDAO.LoadProblemById(id);
            return Ok(problem);
        }
    }
}
