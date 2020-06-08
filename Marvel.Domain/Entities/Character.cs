using Marvel.Domain.Entities.Base;
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
        public List<Url> urls { get; set; }
        public Image thumbnail { get; set; }
        public Comic comics { get; set; }
        public Story stories { get; set; }
        public Event events { get; set; }
        public Serie series { get; set; }


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
