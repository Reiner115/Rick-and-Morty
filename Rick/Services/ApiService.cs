using Newtonsoft.Json;
using Rick_And_Morty.Models;

namespace Rick_And_Morty.Services
{
    public class ApiService
    {
        private static string charactersURL =  "https://rickandmortyapi.com/api/character";

        private static string eposidesURL = "https://rickandmortyapi.com/api/episode";

        public static async Task<List<Character>> GetCharactersAsync()
        {
            

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(charactersURL);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        CharactersResponse charactersResponse = JsonConvert.DeserializeObject<CharactersResponse>(jsonContent);
                        List<Character> characters = charactersResponse.characters;

                        return characters;
                    }
                    else
                    {
                        // Handle unsuccessful response
                        Console.WriteLine($"Failed to retrieve data. Status code: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return null;
                }
            }
        }

        public static async Task<List<Episode>> GetEpisodesAsync()
        {


            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(eposidesURL);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonContent = await response.Content.ReadAsStringAsync();
                        EpisodeResponse episodesResponse = JsonConvert.DeserializeObject<EpisodeResponse>(jsonContent);
                        List<Episode> episodes = episodesResponse.episodes;

                        return episodes;
                    }
                    else
                    {
                        // Handle unsuccessful response
                        Console.WriteLine($"Failed to retrieve data. Status code: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return null;
                }
            }
        }



    }
}
