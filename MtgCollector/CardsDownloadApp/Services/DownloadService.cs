using System.Collections.Generic;
using System.IO;
using System.Linq;
using CardsDownloadApp.Models;
using CardsDownloadApp.Models.MtgJson;
using Newtonsoft.Json;
using Core.CardSets.Contract;
using Core.Cards.Contract;
using Core.CardSets.Models;
using Core.Cards.Models;
using Ninject;

namespace CardsDownloadApp.Services
{
    public class DownloadService
    {
        private readonly IKernel _kernel;
        private readonly ICardSetService _cardSetService;
        private readonly ICardService _cardService;
        private readonly DownloadCardSetsService _downloadCardSetService = new DownloadCardSetsService();
        private readonly DownloadCardsService _downloadCardsService = new DownloadCardsService();

        public DownloadService(IKernel kernel)
        {
            _kernel = kernel;
            _cardSetService = _kernel.Get<ICardSetService>();
            _cardService = _kernel.Get<ICardService>();
        }

        public void DownloadNewOnes()
        {
            List<MtgJsonSet> mtgJsonSets;
            using (var streamReader = new StreamReader(AppSettings.MtgJsonFile))
            {
                string json = streamReader.ReadToEnd();
                mtgJsonSets = JsonConvert.DeserializeObject<List<MtgJsonSet>>(json);
            }

            List<CardSetView> existedCardSets = _cardSetService.Get();
            Dictionary<string, CardSetView> existedCardSetsDictionaryByName = existedCardSets.ToDictionary(s => s.Name.ToUpper());
            Dictionary<string, CardSetModel> newCardSetModelsDictionaryByName =
                _downloadCardSetService.GetNewCardSetModelsDictionaryByName(mtgJsonSets, existedCardSetsDictionaryByName);
            _downloadCardSetService.AddCardSetsToDb(newCardSetModelsDictionaryByName.Values, _cardSetService);

            List<CardView> existedCards = _cardService.Get();
            Dictionary<string, CardView> existedCardsDictionaryByMtgJsonId = existedCards.ToDictionary(c => c.MtgJsonId);
            List<CardModel> newCardModels = _downloadCardsService.GetNewCardModels(mtgJsonSets,
                existedCardSetsDictionaryByName, newCardSetModelsDictionaryByName, existedCardsDictionaryByMtgJsonId);
            _downloadCardsService.AddCardToDb(newCardModels, _cardService);
        }
    }
}
