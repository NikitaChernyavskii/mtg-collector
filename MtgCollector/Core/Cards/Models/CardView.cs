using Core.CardRarities.Models;
using Core.CardSets.Models;

namespace Core.Cards.Models
{
    public class CardView
    {
        public int Id { get; set; }
        public CardSetView CardSet { get; set; }
        public CardRarityView CardRarity { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
    }
}
