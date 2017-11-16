using System.Collections.Generic;
using System.IO;
using System.Linq;
using CardsDownloadApp.Models;
using CardsDownloadApp.Models.MtgJson;
using Core.CardSets.Models;
using Core.CardSets.Services;
using Newtonsoft.Json;

namespace CardsDownloadApp.Services
{
    public class DownloadService
    {
        private readonly CardSetService _cardSetService = new CardSetService();

        public void DownloadAndMerge()
        {
            List<MtgJsonSet> sets;
            using (var streamReader = new StreamReader(AppSettings.MtgJsonFile))
            {
                string json = streamReader.ReadToEnd();
                sets = JsonConvert.DeserializeObject<List<MtgJsonSet>>(json);
            }

            Dictionary<string, CardSetView> existedSets = _cardSetService.Get().ToDictionary(s => s.Name.ToUpper());
            foreach (var set in sets)
            {
                if (existedSets.ContainsKey(set.Name.ToUpper()))
                {
                    
                }
            }
        }
    }
}
