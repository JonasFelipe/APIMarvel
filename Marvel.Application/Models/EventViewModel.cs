using Newtonsoft.Json;
using System.Collections.Generic;

namespace Marvel.Application.Services.Models
{
    public class EventViewModel
    {
        [JsonProperty("available")]
        public int? available { get; set; }

        [JsonProperty("collectionURI")]
        public string collectionURI { get; set; }

        [JsonProperty("items")]
        public List<EventSummaryViewModel> items { get; set; }

        [JsonProperty("returned")]
        public int returned { get; set; }

        public EventViewModel()
        {
            items = new List<EventSummaryViewModel>();
        }
    }
}