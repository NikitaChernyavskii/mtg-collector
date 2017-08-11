using System.Collections.Generic;
using System.Linq;
using Core.CardSets.Contract;
using Core.CardSets.Mapping;
using Core.CardSets.Models;
using DAL.DataBase;
using DAL.DataBase.Contract;
using DAL.Entities;

namespace Core.CardSets.Services
{
    public class CardSetService : ICardSetService
    {
        private IRepository<CardSet> _repository;

        public CardSetService(/*IRepository<CardSet> repository*/)
        {
            // TODO: inject
            _repository = new Repository<CardSet>();
        }


        public List<CardSetView> Get()
        {
            return _repository.Get().Select(c => c.ToView()).ToList();
        }

        public void Add(CardSetModel model)
        {
            _repository.Add(model.ToEntity());
        }

        public void Update(int id, CardSetModel model)
        {
            CardSet cardSetEntity = _repository.Get().First(e => e.Id == id);
            cardSetEntity.Update(model);

            _repository.Update(cardSetEntity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
