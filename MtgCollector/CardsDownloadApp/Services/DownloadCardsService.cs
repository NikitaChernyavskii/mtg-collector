using System;
using System.Collections.Generic;
using CardsDownloadApp.Mapping;
using CardsDownloadApp.Models.MtgJson;
using Core.Cards.Contract;
using Core.Cards.Models;
using Core.CardSets.Models;

namespace CardsDownloadApp.Services
{
    public class DownloadCardsService
    {
        public List<CardModel> GetNewCardModels(List<MtgJsonSet> mtgJsonSets,
            Dictionary<string, CardSetView> existedCardSetsDictionaryByName,
            Dictionary<string, CardSetModel> newCardSetModelsDictionaryByName,
            Dictionary<string, CardView> existedCardsDictionaryByMtgJsonId
            )
        {
            List<CardModel> newCardModels = new List<CardModel>();
            foreach (var mtgJsonSet in mtgJsonSets)
            {
                foreach (var mtgJsonCard in mtgJsonSet.Cards)
                {
                    if (existedCardsDictionaryByMtgJsonId.ContainsKey(mtgJsonCard.MtgJsonId))
                    {
                        continue;
                    }

                    CardModel cardModel = mtgJsonCard.ToModel();
                    if (existedCardSetsDictionaryByName.TryGetValue(mtgJsonSet.Name.ToUpper(), out var existedCardSetView))
                    {
                        cardModel.CardSetId = existedCardSetView.Id;
                    }
                    else if (newCardSetModelsDictionaryByName.TryGetValue(mtgJsonSet.Name.ToUpper(), out var newCardSetModel))
                    {
                        cardModel.CardSetId = newCardSetModel.Id;
                    }
                    else
                    {
                        Console.WriteLine($"ALARM! Card ${mtgJsonCard.Name} with mtgJsonId ${mtgJsonCard.MtgJsonId} doesn`t have set!");
                        continue;
                    }
                    newCardModels.Add(cardModel);
                }
            }

            return newCardModels;
        }

        public void AddCardToDb(IEnumerable<CardModel> newCardModelsDictionaryByMtgJsonId, ICardService cardService)
        {
            // TODO: think about transaction to prevent creation of a lot of contexts
            foreach (var cardModel in newCardModelsDictionaryByMtgJsonId)
            {
                cardService.Add(cardModel);
            }
        }
    }
}
