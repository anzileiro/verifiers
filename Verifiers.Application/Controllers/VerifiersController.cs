using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Verifiers.Domain;

namespace Verifiers.Application.Controllers
{
    [ApiController]
    public class VerifiersController : ControllerBase
    {

        private object CreateResponse(bool valid, string message)
        {
            return new
            {
                valid = valid,
                message = message
            };
        }

        [HttpGet]
        [Route("v1/[controller]/passwords/{value}")]
        public IActionResult IsPasswordValid(string value)
        {
            Console.WriteLine($"The password is {value}");

            try
            {
                new Password(value).Validate();

                return Ok(new
                {
                    valid = true,
                    message = "The password matches all verifiers and it is valid."
                });
            }
            catch (Exception exception)
            {
                return BadRequest(new
                {
                    valid = false,
                    message = exception.Message
                });
            }
        }
    }
}
