using AutoMapper;
using Core.CardRarities.Models;
using Core.Cards.Models;
using Core.CardSets.Models;
using Core.Infrastructure;
using DAL.Entities;

namespace Core.Cards.Mapping
{
    public static class CardMapping
    {
        public static void Register(IMapperConfigurationExpression config)
        {
            config.CreateMap<Card, CardView>()
                .ForMember(c => c.CardSet, expression => expression.MapFrom(src => Mapper.Map<CardSet, CardSetView>(src.CardSet)))
                .ForMember(c => c.CardRarity, expression => expression.MapFrom(src => Mapper.Map<CardRarity, CardRarityView>(src.CardRarity)));
            config.CreateMap<CardModel, Card>()
                .Ignore(c => c.CardSet)
                .Ignore(c => c.CardRarity);
        }

        public static CardView ToView(this Card entity)
        {
            return Mapper.Map<CardView>(entity);
        }

        public static Card ToEntity(this CardModel model)
        {
            return Mapper.Map<Card>(model);
        }

        public static void Update(this Card entity, CardModel model)
        {
            Mapper.Map(model, entity);
        }
    }
}
