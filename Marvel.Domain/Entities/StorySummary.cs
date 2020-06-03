using Marvel.Domain.Entities.Base;
using System.Collections.Generic;

namespace Marvel.Domain.Entities
{
    public class StorySummary : Entity
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
        public string type { get; set; }

        public virtual int StoryId { get; set; }
        public virtual Story Story { get; set; }
    }
}