using Petfolio.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Application.UseCases.Pet.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPetJson Execute()
        {
            return new ResponseAllPetJson
            {
                Pets = new List<ResponseShortPetJson>
                {
                    new ResponseShortPetJson
                    {
                        Id = 1,
                        Name = "Chiquinho",
                        Type = Communication.Enums.PetType.Cat,
                    }
                }
            };
        }
    }
}
