using System.Collections.Generic;
using Core.Cards.Models;

namespace Core.Cards.Contract
{
    public interface ICardService
    {
        List<CardView> Get();
        void Add(CardModel model);
        void Update(int id, CardModel model);
        void Delete(int id);
    }
}
