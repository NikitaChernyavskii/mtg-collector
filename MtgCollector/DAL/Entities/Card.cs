using DAL.DataBase.Models;

namespace DAL.Entities
{
    public class Card : IEntity
    {
        public int Id { get; set; }
        public int CardSetId { get; set; }
        public int CardRarityId { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }

        public virtual CardSet CardSet { get; set; }
        public virtual CardRarity CardRarity { get; set; }
    }
}
