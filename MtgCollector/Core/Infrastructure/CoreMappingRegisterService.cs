using AutoMapper;
using Core.CardRarities.Mapping;
using Core.Cards.Mapping;
using Core.CardSets.Mapping;

namespace Core.Infrastructure
{
    public static class CoreMappingRegisterService
    {
        public static void Register(IMapperConfigurationExpression config)
        {
            CardSetMapping.Register(config);
            CardRarityMapping.Register(config);
            CardMapping.Register(config);
        }
    }
}
