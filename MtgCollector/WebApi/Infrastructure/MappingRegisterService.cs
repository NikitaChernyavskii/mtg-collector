using AutoMapper;
using Core.Infrastructure;

namespace WebApi.Infrastructure
{
    public static class MappingRegisterService
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(config =>
            {
                CoreMappingRegisterService.Register(config);
            });
        }
    }
}