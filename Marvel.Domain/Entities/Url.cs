using Marvel.Domain.Entities.Base;

namespace Marvel.Domain.Entities
{
    public class Url : Entity
    {
        public string type { get; set; }
        public string url { get; set; }
    }
}