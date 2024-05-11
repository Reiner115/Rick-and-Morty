using Newtonsoft.Json;

namespace Rick_And_Morty.Models
{
    public class EpisodeResponse
    {
        public Info info { get; set; }

        [JsonProperty("results")]
        public List<Episode> episodes { get; set; }
    }
}
