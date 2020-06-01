using Marvel.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Text;

namespace Marvel.Domain.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }        
        public DateTime modified { get; set; }
        public string resourceURI { get; set; }
        public List<Url> urls { get; set; }
        public Image thumbnail { get; set; }
        public IList<Comic> comics { get; set; }
        public IList<Story> stories { get; set; }
        public IList<Event> events { get; set; }
        public IList<Serie> series { get; set; }


        public Character()
        {
            thumbnail = new Image();
            comics = new List<Comic>();
            stories = new List<Story>();
            events = new List<Event>();
            series = new List<Serie>();
        }
    }
}
