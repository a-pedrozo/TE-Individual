using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.DAO;
using Capstone.Models;


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

        [HttpGet()] // get to api/problems 
        public ActionResult ListProblems()
        {
            List<TrolleyProblem> problems = trolleyDAO.LoadAllProblems();

            return Ok(problems);
        }
    }
}
