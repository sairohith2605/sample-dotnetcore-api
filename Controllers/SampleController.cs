using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APT_Software_API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APT_Software_API.Controllers
{
    [Route("sampleapi")]
    [ApiController]
    [EnableCors]
    public class SampleController : ControllerBase
    {
        [HttpGet("text")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetSampleMessage()
        {
            return new OkObjectResult(new GenericResponse() { Message = "This is a sample response!" });
        }
    }
}
