using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using Core.CardSets.Contract;
using Core.CardSets.Models;
using Ninject;

namespace WebApi.Controllers
{
    [RoutePrefix("CardSet")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CardSetController : ApiController
    {
        [Inject]
        private ICardSetService CardSetService { get; set; }

        [HttpGet]
        [Route("")]
        public List<CardSetView> Get()
        {
            List<CardSetView> cardSets = CardSetService.Get();

            return cardSets;
        }

        [HttpPost]
        [Route("")]
        public void Add(CardSetModel model)
        {
            CardSetService.Add(model);
        }

        [HttpPut]
        [Route("")]
        public void Update(Guid id, CardSetModel model)
        {
            CardSetService.Update(id, model);
        }

        [HttpDelete]
        [Route("")]
        public void Delete(Guid id)
        {
            CardSetService.Delete(id);
        }
    }
}