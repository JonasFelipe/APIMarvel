using Marvel.Domain.Entities.Base;
using System.Collections.Generic;

namespace Marvel.Domain.Entities
{
    public class EventSummary : Entity
    {
        public string resourceURI { get; set; }
        public string name { get; set; }

        public virtual int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}