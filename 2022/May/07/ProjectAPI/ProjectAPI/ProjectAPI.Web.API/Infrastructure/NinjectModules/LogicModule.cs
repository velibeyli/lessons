using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using ProjectAPI.Web.Logic;
using ProjectAPI.Web.Logic.Infrastructure;

namespace ProjectAPI.Web.API.Infrastructure.NinjectModules
{
    public class LogicModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IRegistrationLogic>().To<RegistrationLogic>().
                WithConstructorArgument("registrationLogic", context => context.Kernel.Get<IRegistrationLogic>());
        }
    }
}