using Newtonsoft.Json;
using System.Collections.Generic;

namespace Marvel.Application.Services.Models
{
    public class StoryViewModel
    {
        [JsonProperty("available")]
        public int? available { get; set; }

        [JsonProperty("collectionURI")]
        public string collectionURI { get; set; }

        [JsonProperty("items")]
        public List<StorySummaryViewModel> items { get; set; }

        [JsonProperty("returned")]
        public int returned { get; set; }

        public StoryViewModel()
        {
            items = new List<StorySummaryViewModel>();
        }
    }
}