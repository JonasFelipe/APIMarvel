using Newtonsoft.Json;
using System.Collections.Generic;

namespace Marvel.Application.Services.Models
{
    public class ComicViewModel
    {
        [JsonProperty("available")]
        public int? available { get; set; }

        [JsonProperty("collectionURI")]
        public string collectionURI { get; set; }

        [JsonProperty("items")]
        public List<ComicSummaryViewModel> items { get; set; }

        [JsonProperty("returned")]
        public int returned { get; set; }

        public ComicViewModel()
        {
            items = new List<ComicSummaryViewModel>();
        }
    }
}