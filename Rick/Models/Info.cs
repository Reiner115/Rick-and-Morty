using Newtonsoft.Json;

namespace Rick_And_Morty.Models
{
    public class Info
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("pages")]
        public int Pages { get; set; }
        [JsonProperty("next")]
        public string Next { get; set; }
        [JsonProperty("prev")]
        public string Prev { get; set; }
    }

}
