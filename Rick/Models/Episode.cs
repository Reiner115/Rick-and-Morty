namespace Rick_And_Morty.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public class Episode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonProperty("air_date")]
        public string AirDate { get; set; }
        [JsonProperty("episode")]
        public string EpisodeCode { get; set; }
        public List<string> Characters { get; set; }
        public string Url { get; set; }
        
        public DateTime Created { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Air Date: {AirDate}, Episode Code: {EpisodeCode}, URL: {Url}, Created: {Created}";
        }
    }

}
