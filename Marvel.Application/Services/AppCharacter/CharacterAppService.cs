using AutoMapper;
using Marvel.Application.Abstration;
using Marvel.Application.Mapping;
using Marvel.Application.Services.Models;
using Marvel.Domain.Abstration.Service.Entities;
using Marvel.Domain.Entities;
using Marvel.Domain.Entities.Models;
using Marvel.Domain.Exceptions;
using Marvel.Domain.MapperConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Application.Services.AppCharacter
{
    public class CharacterAppService : ICharacterAppService
    {
        private readonly ICharacterService _characterService;
        private readonly IMapper _mapper;
        public CharacterAppService(ICharacterService characterService,
            IMapper mapper)
        {
            _characterService = characterService;
            _mapper = mapper;
        }

        public async Task<CharacterViewModel> Add(CharacterInput characterInput)
        {
            var obj = new Character();

            obj = _mapper.Map<Character>(characterInput);

            await _characterService.AddAsync(obj);

            return null;
        }

        public Task<bool?> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CharacterViewModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CharacterDataWrapper> GetCharactersAtParameters(CharacterParameters characterParameters)
        {
            List<CharacterViewModel> result = new List<CharacterViewModel>();

            if (characterParameters.ValidLimit())
                throw new ConflictRequestException("Limit greater than 100.");

            var listcharacter = await _characterService.GetCharactersAtParameters(characterParameters);

            foreach (Character character in listcharacter)
            {
                var obj = _mapper.Map<CharacterViewModel>(character);

                result.Add(obj);
            }

            CharacterDataWrapper characterDataWrapper = new CharacterDataWrapper();


            GetDataWrapper(characterDataWrapper, characterParameters);
            characterDataWrapper.data.total = characterDataWrapper.data.count = result.Count;
            characterDataWrapper.data.results = result;

            return characterDataWrapper;
        }


        public async Task<CharacterViewModel> Update(int id, CharacterInput characterInput)
        {
            var obj = _mapper.Map<Character>(characterInput);

            var result = await _characterService.UpdateAsync(obj);

            var character = _mapper.Map<CharacterViewModel>(result);

            return character;
        }

        private void GetDataWrapper(CharacterDataWrapper characterDataWrapper, CharacterParameters characterParameters)
        {
            characterDataWrapper.Code = 200;
            characterDataWrapper.Status = "OK";
            characterDataWrapper.Copyright = "© 2020 MARVEL";

            characterDataWrapper.AttributionText = "Data provided by Marvel. © 2020 MARVEL";
            characterDataWrapper.AttributionHTML = "<a href=\"http://marvel.com\">Data provided by Marvel. © 2020 MARVEL</a>";
            characterDataWrapper.etag = "b7f6ec76174886d8042748a557e7099ad1151f12";

            characterDataWrapper.data = new CharacterDataContainer();
            characterDataWrapper.data.offset = characterParameters.Offset;
            characterDataWrapper.data.limit = characterParameters.Limit;
        }
    }
}
