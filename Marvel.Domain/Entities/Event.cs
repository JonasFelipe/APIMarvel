using Marvel.Domain.Entities.Base;

namespace Marvel.Domain.Entities
{
    public class Event : Entity
    {
        public int available { get; set; }
        public int returned { get; set; }
        public int collectionURI { get; set; }
        public EventSummary items { get; set; }
    }
}