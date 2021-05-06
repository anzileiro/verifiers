using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Verifiers.Application.ContractObjects;
using Verifiers.Web.Factories;

namespace Verifiers.Web.Controllers
{
    [ApiController]
    public class VerifiersController : ControllerBase
    {

        private readonly PasswordVerifierContractObject _passwordVerifierContractObject;
        private readonly PasswordVerifierResponseFactory _passwordResponseFactory;

        public VerifiersController(PasswordVerifierContractObject passwordVerifierContractObject)
        {
            this._passwordVerifierContractObject = passwordVerifierContractObject;
            this._passwordResponseFactory = new PasswordVerifierResponseFactory();
        }

        [HttpGet]
        [Route("v1/[controller]/passwords/{value}")]
        public IActionResult IsPasswordValid(string value)
        {
            try
            {
                this._passwordVerifierContractObject.execute(value);

                return Ok(this._passwordResponseFactory.ToOk().ToJson());
            }
            catch (Exception exception)
            {
                return BadRequest(this._passwordResponseFactory.ToBadRequest(exception).ToJson());
            }
        }
    }
}