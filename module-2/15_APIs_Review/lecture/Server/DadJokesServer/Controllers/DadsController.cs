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
    public class DadsController : ControllerBase
    {
        private readonly IDadDAO dadDAO;

        public DadsController(IDadDAO dadDAO)
        {
            this.dadDAO = dadDAO;
        }

        [HttpGet]
        public ActionResult GetAllDads()
        {
            List<Dad> dads = dadDAO.GetDads();

            return Ok(dads);
        }

        [HttpGet("{id}")]
        public ActionResult GetDad(int id)
        {
            Dad dad = dadDAO.GetDadById(id);

            if (dad == null)
            {
                return NotFound();
            }

            return Ok(dad);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            dadDAO.DeleteDad(id);

            return NoContent();
        }

        [HttpPost]
        public ActionResult AddDad(Dad dad)
        {
            Dad newDad = dadDAO.InsertDad(dad.Name);

            return Created("dads/" + newDad.Id, newDad);
        }

        [HttpPut]
        public ActionResult UpdateDad(Dad dad)
        {
            Dad updatedDad = dadDAO.UpdateDad(dad);

            if (updatedDad == null)
            {
                return NotFound();
            }

            return Ok(updatedDad);
        }
    }
}
