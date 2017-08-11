using DAL.DataBase;
using DAL.DataBase.Contract;
using Ninject;

namespace DAL.Infrastructure
{
    public static class DalNinjectRegisterBindingService
    {
        public static void Register(IKernel kernel)
        {
            kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>)).InSingletonScope();
        }
    }
}
