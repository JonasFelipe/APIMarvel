using Marvel.Domain.Entities.Base;

namespace Marvel.Domain.Entities
{
    public class Image : Entity
    {
        public string path { get; set; }
        public string extension { get; set; }

        public virtual int CurrentCharacterId { get; set; }
        public virtual Character Character { get; set; }
    }
}