using Athena.Services.DependencyInjection;
using Athena.Services.Modules.FFXIV;
using SimpleInjector;

namespace Athena.Services.Modules
{
    public class BootstrapModules : IBootstrap
    {
        public void RegisterServices(Container container)
        {
            container.Register<IModulesInitializationService, ModulesInitializationService>();

            new BootstrapFFXIVModuleServices()
                .RegisterServices(container);
        }
    }
}
