using System;
using System.Collections.Generic;
using Core.Cards.Models;

namespace Core.Cards.Contract
{
    public interface ICardService
    {
        List<CardView> Get();
        void Add(CardModel model);
        void Update(Guid id, CardModel model);
        void Delete(Guid id);
    }
}
