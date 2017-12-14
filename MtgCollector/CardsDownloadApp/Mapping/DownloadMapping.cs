using System;
using System.Linq;
using AutoMapper;
using CardsDownloadApp.Models.MtgJson;
using Core.Cards.Models;
using Core.CardSets.Models;
using Core.Infrastructure;

namespace CardsDownloadApp.Mapping
{
    public static class DownloadMapping
    {
        public static void Register(IMapperConfigurationExpression config)
        {
            config.CreateMap<MtgJsonSet, CardSetModel>()
                .Ignore(s => s.Id);
            config.CreateMap<MtgJsonCard, CardModel>()
                .ForMember(c => c.Names, expr => expr.MapFrom(src => String.Join(", ", src.Names)))
                .ForMember(c => c.Colors, expr => expr.MapFrom(src => String.Join(", ", src.Colors)))
                .ForMember(c => c.ColorIdentity, expr => expr.MapFrom(src => String.Join(", ", src.ColorIdentity)))
                .ForMember(c => c.Supertypes, expr => expr.MapFrom(src => String.Join(", ", src.Supertypes)))
                .ForMember(c => c.Types, expr => expr.MapFrom(src => String.Join(", ", src.Types)))
                .ForMember(c => c.Subtypes, expr => expr.MapFrom(src => String.Join(", ", src.Subtypes)))
                .ForMember(c => c.Variations, expr => expr.MapFrom(src => String.Join(", ", src.Variations)));
        }

        public static CardSetModel ToModel(this MtgJsonSet mtgJsonSet)
        {
            CardSetModel cardSet = Mapper.Map<CardSetModel>(mtgJsonSet);
            cardSet.Id = Guid.NewGuid();

            return cardSet;
        }

        public static CardModel ToModel(this MtgJsonCard mtgJsonCard)
        {
            return Mapper.Map<CardModel>(mtgJsonCard);
        }
    }
}
