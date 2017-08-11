﻿using System.Collections.Generic;
using System.Web.Http;
using Core.CardSets.Contract;
using Core.CardSets.Models;
using Core.CardSets.Services;
using Ninject;

namespace WebApi.Controllers
{
    [RoutePrefix("CardSet")]
    public class CardSetController : ApiController
    {
        [Inject]
        private ICardSetService _cardSetService { get; set; }

        [HttpGet]
        [Route("")]
        public List<CardSetView> Get()
        {
            List<CardSetView> cardSets = _cardSetService.Get();

            return cardSets;
        }

        [HttpPost]
        [Route("")]
        public void Add(CardSetModel model)
        {
            _cardSetService.Add(model);
        }

        [HttpPut]
        [Route("")]
        public void Update(int id, CardSetModel model)
        {
            _cardSetService.Update(id, model);
        }

        [HttpDelete]
        [Route("")]
        public void Delete(int id)
        {
            _cardSetService.Delete(id);
        }
    }
}