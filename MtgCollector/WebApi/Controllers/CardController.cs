using System.Collections.Generic;
using System.Web.Http;
using Core.Cards.Contract;
using Core.Cards.Models;
using Ninject;

namespace WebApi.Controllers
{
    [RoutePrefix("Card")]
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

        [HttpPost]
        [Route("")]
        public void Add(CardModel model)
        {
            CardService.Add(model);
        }

        [HttpPut]
        [Route("")]
        public void Update(int id, CardModel model)
        {
            CardService.Update(id, model);
        }

        [HttpDelete]
        [Route("")]
        public void Delete(int id)
        {
            CardService.Delete(id);
        }
    }
}