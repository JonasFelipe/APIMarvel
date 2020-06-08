using Marvel.Domain.Abstration.Repository.Entities;
using Marvel.Domain.Entities;
using Marvel.Domain.Entities.Models;
using Marvel.Repository.Context;
using Marvel.Repository.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Repository.Repositories.Entities
{
    public class CharacterRepository : RepositoryBase<Character>, ICharacterRepository
    {
        private readonly MarvelContext marvelContext;

        public CharacterRepository(MarvelContext context)
            : base(context)
        {
            marvelContext = context;
        }

        public Task<IList<Character>> GetCharacterAtParameters(CharacterParameters characterParameters)
        {
            return null;
        }
    }
}
