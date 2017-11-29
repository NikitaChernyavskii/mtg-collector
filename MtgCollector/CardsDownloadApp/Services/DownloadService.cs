using System.Collections.Generic;
using System.IO;
using System.Linq;
using CardsDownloadApp.Models;
using CardsDownloadApp.Models.MtgJson;
using Core.CardSets.Services;
using Newtonsoft.Json;
using Core.CardSets.Contract;
using Core.Cards.Services;
using Core.Cards.Contract;
using Core.CardSets.Models;
using CardsDownloadApp.Mapping;
using Ninject;

namespace CardsDownloadApp.Services
{
    public class DownloadService
    {
        private readonly IKernel _kernel;
        private readonly ICardSetService _cardSetService;
        private readonly ICardService _cardService = new CardService();
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

            var existedSets = new HashSet<string>(_cardSetService.Get().Select(s => s.Name.ToUpper()));
            List<CardSetModel> setModels = new List<CardSetModel>();
            foreach (var mtgJsonSet in mtgJsonSets)
            {
                if (existedSets.Contains(mtgJsonSet.Name.ToUpper()))
                {
                    continue;
                }
                setModels.Add(mtgJsonSet.ToModel());
            }
            AddCardSetsToDb(setModels);
        }

        private void AddCardSetsToDb(List<CardSetModel> setModels)
        {
            // TODO: think about transaction to prevent creation of a lot of contexts
            foreach(var setModel in setModels)
            {
                _cardSetService.Add(setModel);
            }
        }
    }
}
