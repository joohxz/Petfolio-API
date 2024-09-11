using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pet.Register;
using Petfolio.Application.UseCases.Pet.Update;
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
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public IActionResult RegisterPet([FromBody] RequestRegisterPetJson request)
        {
            var response = new RegisterPetUseCase().Execute(request);
            return Created(string.Empty, response);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdatePet([FromRoute] int id, [FromBody] RequestRegisterPetJson request)
        {
            var useCase = new UpdatePetUseCase();
            useCase.Execute(id, request);
            return NoContent();
        }
    }
}
