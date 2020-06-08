using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.Entities.Models
{
    public class CharacterParameters : QueryStringParameters
    {
        public const int limited = 100;

        public string Name { get; set; }
        public string NameStartsWith { get; set; }
        public DateTime? ModifiedSince { get; set; }
        public int? Comics { get; set; }
        public int? Series { get; set; }
        public int? Events { get; set; }
        public int? Stories { get; set; }


        public int? Limit { get; set; }
        public int? Offset { get; set; }

        public bool ValidLimit()
        {
            if (!Limit.HasValue)
                return false;

            return Limit > limited || Limit <= 0;
        }

    }
}
