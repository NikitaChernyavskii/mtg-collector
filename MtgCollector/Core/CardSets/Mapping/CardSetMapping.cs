using AutoMapper;
using Core.CardSets.Models;
using DAL.Entities;

namespace Core.CardSets.Mapping
{
    public static class CardSetMapping
    {
        public static void Register(IMapperConfigurationExpression config)
        {
            config.CreateMap<CardSet, CardSetView>();
            config.CreateMap<CardSetModel, CardSet>();
        }

        public static CardSetView ToView(this CardSet dbEntity)
        {
            return Mapper.Map<CardSetView>(dbEntity);
        }

        public static CardSet ToEntity(this CardSetModel model)
        {
            return Mapper.Map<CardSet>(model);
        }

        public static void Update(this CardSet dbEntity, CardSetModel model)
        {
            
        }
    }
}
