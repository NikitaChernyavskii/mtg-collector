using AutoMapper;
using Core.CardRarities.Models;
using DAL.Entities;

namespace Core.CardRarities.Mapping
{
    public static class CardRarityMapping
    {
        public static void Register(IMapperConfigurationExpression config)
        {
            config.CreateMap<CardRarity, CardRarityView>();
        }

        public static CardRarityView ToView(this CardRarity entity)
        {
            return Mapper.Map<CardRarityView>(entity);
        }
    }
}
