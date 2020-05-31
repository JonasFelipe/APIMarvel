using Marvel.Domain.Entities.Base;

namespace Marvel.Domain.Entities
{
    public class SerieSummary : Entity
    {
        public string resourceURI { get; set; }
        public string name { get; set; }
    }
}