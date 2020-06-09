using Marvel.Application.Abstration;
using Marvel.Application.Services.Models;
using Marvel.Domain.Entities.Models;
using Marvel.Ioc;
using MarvelAPP.API.Controllers;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Marvel.API.Tests.TestController
{
    public class CharacterControllerTest : UnitBaseTest
    {
        private ICharacterAppService _characterAppService;
        public CharacterControllerTest()
        {
            ConfigurarAppSerice();
        }

        [Fact]
        public void GetSuccessData()
        {
            CharacterController controller = new CharacterController(_characterAppService);

            var result = controller.Get(new CharacterParameters());
            Assert.True(true, "Error access controller");
        }

        [Fact]
        public void GetSuccessSpeficiedCharacter()
        {
            var result = _characterAppService.GetCharactersAtParameters(new CharacterParameters{ Name = "Spider-Man" });
            Assert.True(result.IsCompletedSuccessfully,"Error get Character");
        }

        private void ConfigurarAppSerice()
        {
            _characterAppService = Substitute.For<ICharacterAppService>();

            OverrideRegistration<ICharacterAppService>((provider) => _characterAppService);
        }


    }
}
