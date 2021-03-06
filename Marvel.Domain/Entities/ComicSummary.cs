﻿using Marvel.Domain.Entities.Base;

namespace Marvel.Domain.Entities
{
    public class ComicSummary : Entity
    {
        public string resourceURI { get; set; }
        public string name { get; set; }

        public virtual int ComicId { get; set; }
        public virtual Comic Comic { get; set; }
    }
}