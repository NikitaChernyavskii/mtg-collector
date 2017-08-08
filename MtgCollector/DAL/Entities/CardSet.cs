using System.Collections.Generic;
using DAL.DataBase.Models;

namespace DAL.Entities
{
    public class CardSet : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
    }
}
