using System.Collections.Generic;
using Core.CardSets.Models;

namespace Core.CardSets.Contract
{
    public interface ICardSetService
    {
        List<CardSetView> Get();

        void Add(CardSetModel model);

        void Update(int id, CardSetModel model);

        void Delete(int id);
    }
}
