﻿using Marvel.Domain.Entities.Base;
using System.Collections.Generic;

namespace Marvel.Domain.Entities
{
    public class Event : Entity
    {
        public int available { get; set; }
        public int returned { get; set; }
        public int collectionURI { get; set; }
        public IList<EventSummary> items { get; set; }

        public virtual int CharacterId { get; set; }
        public virtual Character Character { get; set; }
    }
}