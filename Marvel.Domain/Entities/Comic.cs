using Marvel.Domain.Entities.Base;
using System.Collections.Generic;

namespace Marvel.Domain.Entities
{
    public class Comic : Entity
    {
        public int available { get; set; }
        public int returned { get; set; }
        public string collectionURI { get; set; }
        public ComicSummary items { get; set; }

        public virtual int CurrentCharacterId { get; set; }
        public virtual IList<Character> Character { get; set; }
    }
}