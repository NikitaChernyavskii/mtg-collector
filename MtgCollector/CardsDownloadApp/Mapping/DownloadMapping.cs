using AutoMapper;
using CardsDownloadApp.Models.MtgJson;
using Core.Cards.Models;
using Core.CardSets.Models;

namespace CardsDownloadApp.Mapping
{
    public static class DownloadMapping
    {
        public static void Register(IMapperConfigurationExpression config)
        {
            config.CreateMap<MtgJsonCard, CardModel>();
            config.CreateMap<MtgJsonSet, CardSetModel>();
        }

        public static CardModel ToModel(this MtgJsonCard mtgJsonCard)
        {
            return Mapper.Map<CardModel>(mtgJsonCard);
        }

        public static CardSetModel ToModel(this MtgJsonSet mtgJsonSet)
        {
            return Mapper.Map<CardSetModel>(mtgJsonSet);
        }
    }
}
