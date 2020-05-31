using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.Entities.Base
{
    public abstract class Entity
    {
        public int Id { get; protected set; }
    }
}
