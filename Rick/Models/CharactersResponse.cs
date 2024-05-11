using Newtonsoft.Json;

namespace Rick_And_Morty.Models
{
    public class CharactersResponse
    {

        public Info Info { get; set; }

        [JsonProperty("results")]
        public List<Character> characters;



    }
}
