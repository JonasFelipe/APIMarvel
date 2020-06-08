using Marvel.Application.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.Entities
{
    public class CharacterDataWrapper
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public string Copyright { get; set; }
        public string AttributionText { get; set; }
        public string AttributionHTML { get; set; }
        public CharacterDataContainer data { get; set; }
        public string etag { get; set; }
    }
}
