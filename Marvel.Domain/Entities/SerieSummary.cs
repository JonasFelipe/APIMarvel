using Marvel.Domain.Entities.Base;

namespace Marvel.Domain.Entities
{
    public class SerieSummary : Entity
    {
        public string resourceURI { get; set; }
        public string name { get; set; }

        public virtual int SerieId { get; set; }
        public virtual Serie Serie { get; set; }
    }
}