using System;
using System.Collections.Generic;
using Core.CardSets.Models;

namespace Core.CardSets.Contract
{
    public interface ICardSetService
    {
        List<CardSetView> Get();

        void Add(CardSetModel model);

        void Update(Guid id, CardSetModel model);

        void Delete(Guid id);
    }
}
