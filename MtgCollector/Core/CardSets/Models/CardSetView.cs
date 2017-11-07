using Newtonsoft.Json;

namespace Core.CardSets.Models
{
    public class CardSetView
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
