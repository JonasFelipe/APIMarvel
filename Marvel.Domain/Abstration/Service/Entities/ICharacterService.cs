using Marvel.Domain.Abstration.Service.Base;
using Marvel.Domain.Entities;
using Marvel.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Domain.Abstration.Service.Entities
{
    public interface ICharacterService : IServiceBase<Character>
    {
        Task<IList<Character>> GetCharactersAtParameters(CharacterParameters characterParameters);
    }
}
