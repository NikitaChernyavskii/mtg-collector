using AutoMapper;
using Core.CardSets.Mapping;

namespace Core.Infrastructure
{
    public static class CoreMappingRegisterService
    {
        public static void Register(IMapperConfigurationExpression config)
        {
            CardSetMapping.Register(config);
        }
    }
}
