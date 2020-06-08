using Marvel.Domain.Entities.Base;
using System.Collections.Generic;

namespace Marvel.Domain.Entities
{
    public class Serie : Entity
    {
        public int? available { get; set; }
        public string collectionURI { get; set; }
        public virtual IList<SerieSummary> items { get; set; }

        public virtual int CharacterId { get; set; }
        public virtual Character Character { get; set; }

        public Serie()
        {
            items = new List<SerieSummary>();
        }
    }
}