using System.Collections.Generic;
using System.Linq;
using Core.CardSets.Contract;
using Core.CardSets.Mapping;
using Core.CardSets.Models;
using DAL.DataBase.Contract;
using DAL.Entities;
using Ninject;

namespace Core.CardSets.Services
{
    public class CardSetService : ICardSetService
    {
        [Inject]
        private IRepository<CardSet> _repository { get; set; }

        public List<CardSetView> Get()
        {
            return _repository.Get().ToList().Select(c => c.ToView()).ToList();
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
