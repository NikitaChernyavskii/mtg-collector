using System.Web.Http;
using Core.Infrastructure;
using DAL.Infrastructure;
using Ninject;
using WebApi.Infrastructure;

namespace WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            InitializeNinject();
            RegisterRoutes(config);
            MappingRegisterService.RegisterMappings();
        }

        private static void InitializeNinject()
        {
            IKernel kernel = NinjectWebCommon.Bootstrapper.Kernel;
            DalNinjectRegisterBindingService.Register(kernel);
            CoreNinjectRegisterBindingService.Register(kernel);
        }

        private static void RegisterRoutes(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
