using System.CodeDom;
using Core.Cards.Contract;
using Core.Cards.Services;
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
            kernel.Bind<ICardService>().To<CardService>();
        }
    }
}
