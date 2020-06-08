using Marvel.Domain.Abstration.Repository.Entities;
using Marvel.Domain.Abstration.Service.Entities;
using Marvel.Domain.Entities;
using Marvel.Domain.Entities.Models;
using Marvel.Domain.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Domain.Services
{   
    public class CharacterService : ServiceBase<Character>, ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;

        public CharacterService(ICharacterRepository characterRepository)
                : base(characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public async Task<IList<Character>> GetCharactersAtParameters(CharacterParameters characterParameters)
        {
            var result = await _characterRepository.GetCharacterAtParameters(characterParameters);
            
            return result;
        }
    }
}
