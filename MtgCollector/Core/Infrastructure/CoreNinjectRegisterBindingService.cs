using System.CodeDom;
using Core.CardSets.Contract;
using Core.CardSets.Services;
using Ninject;

namespace Core.Infrastructure
{
    public static class CoreNinjectRegisterBindingService
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind<ICardSetService>().To<CardSetService>();
        }
    }
}
