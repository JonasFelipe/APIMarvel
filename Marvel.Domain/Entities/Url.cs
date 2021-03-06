﻿using Marvel.Domain.Entities.Base;
using System.Collections.Generic;

namespace Marvel.Domain.Entities
{
    public class Url : Entity
    {
        public string type { get; set; }
        public string url { get; set; }

        public virtual int CharacterId { get; set; }
        public virtual Character Character { get; set; }
    }
}