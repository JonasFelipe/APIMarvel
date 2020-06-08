using Marvel.Domain.Entities.Base;
using System.Collections.Generic;

namespace Marvel.Domain.Entities
{
    public class Comic : Entity
    {
        public int? available { get; set; }
        public string collectionURI { get; set; }
        public IList<ComicSummary> items { get; set; }

        public virtual int CharacterId { get; set; }
        public virtual Character Character { get; set; }

        public Comic()
        {
            items = new List<ComicSummary>();
        }
    }
}