using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using Core.Cards.Contract;
using Core.Cards.Models;
using Ninject;

namespace WebApi.Controllers
{
    [RoutePrefix("Card")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CardController : ApiController
    {
        [Inject]
        private ICardService CardService { get; set; }

        [HttpGet]
        [Route("")]
        public List<CardView> Get()
        {
            return CardService.Get();
        }

        [HttpGet]
        [Route("id/{id}")]
        public CardView GetById(Guid id)
        {
            return CardService.GetById(id);
        }

        [HttpGet]
        [Route("setId/{setId}")]
        public List<CardView> GetBySetId(Guid setId)
        {
            var test = CardService.GetBySetId(setId);
            return CardService.GetBySetId(setId);
        }

        [HttpPost]
        [Route("")]
        public void Add(CardModel model)
        {
            CardService.Add(model);
        }

        [HttpPut]
        [Route("")]
        public void Update(Guid id, CardModel model)
        {
            CardService.Update(id, model);
        }

        [HttpDelete]
        [Route("")]
        public void Delete(Guid id)
        {
            CardService.Delete(id);
        }
    }
}