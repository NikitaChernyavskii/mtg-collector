using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
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
                .ForMember(view => view.CardSet, expr => expr.MapFrom(entity => 
                    Mapper.Map<CardSet, CardSetView>(entity.CardSet)))
                .ForMember(view => view.Names, expr => expr.MapFrom(entity => SplitToArray(entity.Names)))
                .ForMember(view => view.Colors, expr => expr.MapFrom(entity => SplitToArray(entity.Colors)))
                .ForMember(view => view.ColorIdentity, expr => expr.MapFrom(entity => SplitToArray(entity.ColorIdentity)))
                .ForMember(view => view.Supertypes, expr => expr.MapFrom(entity => SplitToArray(entity.Supertypes)))
                .ForMember(view => view.Types, expr => expr.MapFrom(entity => SplitToArray(entity.Types)))
                .ForMember(view => view.Subtypes, expr => expr.MapFrom(entity => SplitToArray(entity.Subtypes)))
                .ForMember(view => view.Variations, expr => expr.MapFrom(entity => SplitToIntArray(entity.Variations)));
            config.CreateMap<CardModel, Card>()
                .Ignore(c => c.CardSet);
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

        private static IEnumerable<string> SplitToArray(string entities)
        {
            return entities?.Split(',').Select(colorIdentity => colorIdentity.Trim()) ?? new List<string>();
        }

        private static IEnumerable<int> SplitToIntArray(string entities)
        {
            return entities?.Split(',').Select(colorIdentity => Int32.Parse(colorIdentity.Trim())) ?? new List<int>();
        }
    }
}
