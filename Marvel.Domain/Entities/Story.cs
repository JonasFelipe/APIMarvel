using Marvel.Domain.Entities.Base;
using System.Collections.Generic;

namespace Marvel.Domain.Entities
{
    public class Story : Entity
    {
        public int available { get; set; }
        public int returned { get; set; }
        public string collectionURI { get; set; }
        public List<StorySummary> items { get; set; }
    }
}