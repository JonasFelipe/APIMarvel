using System.Collections.Generic;

namespace Marvel.Application.Services.Models
{
    public class CharacterDataContainer
    {
        public int offset { get; set; }
        public int limit { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public List<CharacterViewModel> results { get; set; }
    }
}