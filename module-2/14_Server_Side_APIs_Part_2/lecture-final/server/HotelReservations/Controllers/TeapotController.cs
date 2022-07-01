using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeapotController : ControllerBase
    {
        [HttpGet()]
        public ActionResult EasterEgg()
        {
            return StatusCode(418, "I'm a little teapot short and stout...");
        }
    }
}
