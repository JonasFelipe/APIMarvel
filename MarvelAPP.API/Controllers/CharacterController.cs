using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Marvel.Application.Abstration;
using Marvel.Application.Services.Models;
using Marvel.Domain.Entities.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarvelAPP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        public readonly ICharacterAppService _characterAppService;

        public CharacterController(ICharacterAppService characterAppService)
        {
            _characterAppService = characterAppService;
        }

        // GET: api/<CharacterController>
        [HttpGet]
        public ActionResult Get([FromQuery] CharacterParameters charaterParameters)
        {
            var result = _characterAppService.GetCharactersAtParameters(charaterParameters);

            if (result.Status == TaskStatus.Faulted)
                return Conflict(new { code = 409, status = result.Exception.InnerException.Message});

            return Ok(result);
        }

        // GET api/<CharacterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CharacterController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] List<CharacterInput> charactersInput)
        {
            if (ModelState.IsValid)
            {
                List<CharacterViewModel> characters = new List<CharacterViewModel>();
                    
                foreach (var character in charactersInput)
                {
                    var result = await _characterAppService.Add(character);

                    characters.Add(result);
                }

                return Ok("Ok");
            }

            return BadRequest(ModelState);
        }

        // PUT api/<CharacterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CharacterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
