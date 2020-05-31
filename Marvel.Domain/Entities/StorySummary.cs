using Marvel.Domain.Entities.Base;

namespace Marvel.Domain.Entities
{
    public class StorySummary : Entity
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }
}