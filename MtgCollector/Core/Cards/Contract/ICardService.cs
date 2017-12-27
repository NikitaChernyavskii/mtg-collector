using System;
using System.Collections.Generic;
using Core.Cards.Models;

namespace Core.Cards.Contract
{
    public interface ICardService
    {
        List<CardView> Get();
        CardView GetById(Guid id);
        List<CardView> GetBySetId(Guid setId);
        void Add(CardModel model);
        void Update(Guid id, CardModel model);
        void Delete(Guid id);
    }
}
