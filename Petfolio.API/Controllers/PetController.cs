﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pet.Register;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponsePetRegisteredJson), StatusCodes.Status201Created)]
        public IActionResult RegisterPet([FromBody] RequestRegisterPetJson request)
        {
            var response = new RegisterPetUseCase().Execute(request);
            return Ok(response);
        }
    }
}
