using Marvel.Application.Services.Models;
using Marvel.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Application.Abstration
{
    public interface ICharacterAppService
    {
        Task<CharacterViewModel> GetById(int id);
        Task<CharacterViewModel> Add(CharacterInput characterInput);
        Task<bool?> Delete(int id);
        Task<CharacterViewModel> Update(int id, CharacterInput characterInput);
        Task<CharacterDataWrapper> GetCharactersAtParameters(CharacterParameters characterParameters);
    }
}
