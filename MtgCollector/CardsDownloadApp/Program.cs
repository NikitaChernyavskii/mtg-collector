using AutoMapper;
using CardsDownloadApp.Mapping;
using CardsDownloadApp.Services;
using Core.Infrastructure;
using DAL.Infrastructure;
using Ninject;
using WebApi;

namespace CardsDownloadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // HACK. DO NOT USE REF TO WEBVB API
            IKernel kernel = NinjectWebCommon.CreateKernel();
            DalNinjectRegisterBindingService.Register(kernel);
            CoreNinjectRegisterBindingService.Register(kernel);



            Mapper.Initialize(config =>
            {
                CoreMappingRegisterService.Register(config);
                DownloadMapping.Register(config);
            });


            var test = new DownloadService(kernel);
            test.DownloadNewOnes();
        }
    }
}
