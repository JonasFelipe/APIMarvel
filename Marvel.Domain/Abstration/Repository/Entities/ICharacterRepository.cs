using Marvel.Domain.Abstration.Repository.Base;
using Marvel.Domain.Entities;
using Marvel.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Domain.Abstration.Repository.Entities
{
    public interface ICharacterRepository : IRepositoryBase<Character>
    {
        Task<IList<Character>> GetCharacterAtParameters(CharacterParameters characterParameters);
    }
}
