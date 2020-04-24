using Athena.Models.Application;
using Athena.Services.DependencyInjection;
using SimpleInjector;

namespace Athena.Services.Application
{
    class BootstrapApplication : IBootstrap
    {
        public void RegisterServices(Container container)
        {
            container.Register<ApplicationGameModulesListModel>(Lifestyle.Singleton);
            container.Register<IApplicationUpdateGameModulesService, ApplicationUpdateGameModulesService>();
        }
    }
}
