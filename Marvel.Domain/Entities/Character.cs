using Marvel.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Domain.Entities
{
    public class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }        
        public DateTime modified { get; set; }
        public string resourceURI { get; set; }
        public List<Url> urls { get; set; }
        public Image thumbnail { get; set; }
        public List<Comic> comics { get; set; }
        public List<Story> stories { get; set; }
        public List<Event> events { get; set; }
        public List<Serie> series { get; set; }
    }
}
