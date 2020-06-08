using Marvel.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Text;

namespace Marvel.Domain.Entities
{
    public class Character : Entity
    {
        public string name { get; set; }
        public string description { get; set; }        
        public DateTime modified { get; set; }
        public string resourceURI { get; set; }
        public virtual List<Url> urls { get; set; }
        public virtual Image thumbnail { get; set; }
        public virtual Comic comics { get; set; }
        public virtual Story stories { get; set; }
        public virtual Event events { get; set; }
        public virtual Serie series { get; set; }


        public Character()
        {
            urls = new List<Url>();
            thumbnail = new Image();
            comics =  new Comic();
            stories = new Story();
            events =  new Event();
            series =  new Serie();
        }
    }
}
