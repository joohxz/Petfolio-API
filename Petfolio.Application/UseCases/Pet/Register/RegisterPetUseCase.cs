using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Register
{
    public class RegisterPetUseCase
    {
        public ResponsePetRegisteredJson Execute(RequestRegisterPetJson request)
        {
            return new ResponsePetRegisteredJson
            {
                Id = 7,
                Name = request.Name
            };
        }
    }
}
