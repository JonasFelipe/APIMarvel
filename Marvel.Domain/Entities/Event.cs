using Marvel.Domain.Entities.Base;
using System.Collections.Generic;

namespace Marvel.Domain.Entities
{
    public class Event : Entity
    {
        public int? available { get; set; }
        public string collectionURI { get; set; }
        public virtual IList<EventSummary> items { get; set; }

        public virtual int CharacterId { get; set; }
        public virtual Character Character { get; set; }

        public Event()
        {
            items = new List<EventSummary>();
        }
    }
}