using Marvel.Application.Services.Models;
using Marvel.Domain.Entities;
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
        Task<CharacterViewModel> Add(CharacterInput compraGadoInput);
        Task<bool?> Delete(int id);
        Task<CharacterViewModel> Update(int id, CharacterInput compraGadoViewModel);
        Task<IList<CharacterViewModel>> GetCharactersAtParameters(CharacterParameters characterParameters);
    }
}
