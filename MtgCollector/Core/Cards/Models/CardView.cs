//using Core.CardRarities.Models;

using System;
using Core.CardSets.Models;
using Newtonsoft.Json;

namespace Core.Cards.Models
{
    public class CardView
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("mtgJsonId")]
        public string MtgJsonId { get; set; }

        [JsonProperty("cardSetId")]
        public int CardSetId { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public string[] Names { get; set; }

        [JsonProperty("manaCost")]
        public string ManaCost { get; set; }

        [JsonProperty("cmc")]
        public double Cmc { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("colorIdentity")]
        public string[] ColorIdentity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("supertypes")]
        public string[] Supertypes { get; set; }

        [JsonProperty("types")]
        public string[] Types { get; set; }

        [JsonProperty("subtypes")]
        public string[] Subtypes { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("flavor")]
        public string Flavor { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("toughness")]
        public string Toughness { get; set; }

        [JsonProperty("loyalty")]
        public int? Loyalty { get; set; }

        [JsonProperty("multiverseid")]
        public int Multiverseid { get; set; }

        [JsonProperty("variations")]
        public int[] Variations { get; set; }

        [JsonProperty("imageName")]
        public string ImageName { get; set; }

        [JsonProperty("watermark")]
        public string Watermark { get; set; }

        [JsonProperty("border")]
        public string Border { get; set; }

        [JsonProperty("timeshifted")]
        public bool Timeshifted { get; set; }

        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonIgnore]
        public CardSetView CardSet { get; set; }
    }
}
