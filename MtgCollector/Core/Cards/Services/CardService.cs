using System;
using System.Collections.Generic;
using Core.Cards.Contract;
using Core.Cards.Models;
using DAL.DataBase.Contract;
using DAL.Entities;
using Ninject;
using System.Linq;
using Core.Cards.Mapping;


namespace Core.Cards.Services
{
    public class CardService : ICardService
    {
        [Inject]
        private IRepository<Card> CardRepository { get; set; }

        public List<CardView> Get()
        {
            List<CardView> cards = CardRepository
                //.Get(c => c.CardSet, c => c.CardRarity)
                .Get(c => c.CardSet)
                .Select(c => c.ToView())
                .ToList();

            return cards;
        }

        public void Add(CardModel model)
        {
            Card entity = model.ToEntity();
            entity.Id = Guid.NewGuid();
            CardRepository.Add(entity);
        }

        public void Update(Guid id, CardModel model)
        {
            Card entity = CardRepository.Get().First(e => e.Id == id);
            entity.Update(model);

            CardRepository.Update(entity);
        }

        public void Delete(Guid id)
        {
            CardRepository.Delete(id);
        }
    }
}
