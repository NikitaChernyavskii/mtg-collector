using System;
using Newtonsoft.Json;

namespace Core.CardSets.Models
{
    public class CardSetView
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("gathererCode")]
        public string GathererCode { get; set; }

        [JsonProperty("oldCode")]
        public string OldCode { get; set; }

        [JsonProperty("magicCardsInfoCode")]
        public string MagicCardsInfoCode { get; set; }

        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonProperty("border")]
        public string Border { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("block")]
        public string Block { get; set; }

        [JsonProperty("onlineOnly")]
        public bool OnlineOnly { get; set; }
    }
}
