using Marvel.Domain.Entities.Base;

namespace Marvel.Domain.Entities
{
    public class Serie : Entity
    {
        public int available { get; set; }
        public int returned { get; set; }
        public string collectionURI { get; set; }
        public SerieSummary items { get; set; }        
    }
}