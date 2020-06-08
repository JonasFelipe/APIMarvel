using Marvel.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.Application.Services.Models
{
    public class CharacterInput
    {
        [JsonProperty("name")]
        public string name { get; set; }
        public string description { get; set; }
        public DateTime modified { get; set; }
        public string resourceURI { get; set; }
        public List<UrlViewModel> urls { get; set; }    
        public ImageViewModel thumbnail { get; set; }
        public ComicViewModel comics { get; set; }
        public StoryViewModel stories { get; set; }
        public EventViewModel events { get; set; }
        public SerieViewModel series { get; set; }

        public CharacterInput()
        {
            urls = new List<UrlViewModel>();
            thumbnail = new ImageViewModel();
            comics =  new ComicViewModel();
            stories = new StoryViewModel();
            events =  new EventViewModel();
            series =  new SerieViewModel();
        }
    }
}
