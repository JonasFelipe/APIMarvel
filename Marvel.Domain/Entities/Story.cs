using Marvel.Domain.Entities.Base;
using System.Collections.Generic;

namespace Marvel.Domain.Entities
{
    public class Story : Entity
    {
        public int? available { get; set; }
        public string collectionURI { get; set; }
        public virtual  List<StorySummary> items { get; set; }

        public virtual int CharacterId { get; set; }
        public virtual Character Character { get; set; }

        public Story()
        {
            items = new List<StorySummary>();
        }
    }
}