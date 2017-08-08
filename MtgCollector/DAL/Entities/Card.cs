namespace DAL.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public int CardSetId { get; set; }
        public string ImageName { get; set; }

        public virtual CardSet CardSet { get; set; }
    }
}
