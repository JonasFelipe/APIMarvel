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

            //return obj.MapTo<CompraGadoViewModel>();

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

        public async Task<IList<CharacterViewModel>> GetCharactersAtParameters(CharacterParameters characterParameters)
        {
            if (characterParameters.ValidLimit())
                throw new ConflictRequestException("Limit greater than 100.");

            var obj = await _characterService.GetCharactersAtParameters(characterParameters);

            //return obj.MapTo<List<CharacterViewModel>>();

            return null;
        }

        public Task<CharacterViewModel> Update(int id, CharacterInput compraGadoViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
