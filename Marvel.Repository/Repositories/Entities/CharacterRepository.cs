using Marvel.Domain.Abstration.Repository.Entities;
using Marvel.Domain.Entities;
using Marvel.Domain.Entities.Models;
using Marvel.Repository.Context;
using Marvel.Repository.Repositories.Base;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

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

        public async Task<IList<Character>> GetCharacterAtParameters(CharacterParameters characterParameters)
        {
            try
            {
                List<Character> characters = new List<Character>();

                var nameCharacter = characterParameters.Name == null ? "" : characterParameters.Name;
                var startName = characterParameters.NameStartsWith == null ? "" : characterParameters.NameStartsWith;
                var dtModified = characterParameters.ModifiedSince == null ? DateTime.Parse(SqlDateTime.MinValue.ToString()) : characterParameters.ModifiedSince;
                var idComic = characterParameters.Comics == null ? "" : characterParameters.Comics.ToString();
                var idEvent = characterParameters.Events == null ? "" : characterParameters.Events.ToString();
                var idSerie = characterParameters.Series == null ? "" : characterParameters.Series.ToString();
                var idStory = characterParameters.Stories == null ? "" : characterParameters.Stories.ToString();

                var query = ((from character in marvelContext.Character
                              join comic in marvelContext.Comic on character.Id equals comic.CharacterId
                              join events in marvelContext.Event on character.Id equals events.CharacterId
                              join story in marvelContext.Story on character.Id equals story.CharacterId
                              join serie in marvelContext.Serie on character.Id equals serie.CharacterId
                              join url in marvelContext.Url on character.Id equals url.CharacterId
                              where (
                                     comic.items.Any(x => x.resourceURI.Contains(idComic))
                                     && serie.items.Any(y => y.resourceURI.Contains(idSerie))
                                     && story.items.Any(z => z.resourceURI.Contains(idStory))
                                     && events.items.Any(a => a.resourceURI.Contains(idEvent)))
                              select character
                            )).Where(x => x.name.Equals(nameCharacter) || x.name.StartsWith(startName)
                                     && x.modified >= dtModified).Distinct().Take(characterParameters.Limit ?? 100).AsQueryable();

                characters = query.ToList();
               

                return characters;
            }
            catch (SqlException ex)
            {

                throw ex;

            }
        }
    }
}
