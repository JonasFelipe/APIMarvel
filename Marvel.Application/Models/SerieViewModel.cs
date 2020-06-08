using Newtonsoft.Json;
using System.Collections.Generic;

namespace Marvel.Application.Services.Models
{
    public class SerieViewModel
    {
        [JsonProperty("available")]
        public int? available { get; set; }

        [JsonProperty("collectionURI")]
        public string collectionURI { get; set; }

        [JsonProperty("items")]
        public List<SerieSummaryViewModel> items { get; set; }

        [JsonProperty("returned")]
        public int returned { get; set; }


        public SerieViewModel()
        {
            items = new List<SerieSummaryViewModel>();
        }
    }
}