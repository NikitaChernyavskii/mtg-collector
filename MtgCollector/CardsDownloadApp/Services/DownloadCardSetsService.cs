using System.Collections.Generic;
using CardsDownloadApp.Mapping;
using CardsDownloadApp.Models.MtgJson;
using Core.CardSets.Contract;
using Core.CardSets.Models;

namespace CardsDownloadApp.Services
{
    public class DownloadCardSetsService
    {
        public Dictionary<string, CardSetModel> GetNewCardSetModelsDictionaryByName(List<MtgJsonSet> mtgJsonSets,
            Dictionary<string, CardSetView> existedSetsByName)
        {
            Dictionary<string, CardSetModel> newSetModelsDictionaryByName = new Dictionary<string, CardSetModel>();
            foreach (var mtgJsonSet in mtgJsonSets)
            {
                if (existedSetsByName.ContainsKey(mtgJsonSet.Name.ToUpper()))
                {
                    continue;
                }
                newSetModelsDictionaryByName.Add(mtgJsonSet.Name, mtgJsonSet.ToModel());
            }

            return newSetModelsDictionaryByName;
        }

        public void AddCardSetsToDb(IEnumerable<CardSetModel> setModels, ICardSetService cardSetService)
        {
            // TODO: think about transaction to prevent creation of a lot of contexts
            foreach (var setModel in setModels)
            {
                cardSetService.Add(setModel);
            }
        }
    }
}
